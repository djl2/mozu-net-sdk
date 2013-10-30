using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mozu.Api.Contracts.AppDev;
using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.Tenant;
using Mozu.Api.Resources.Platform;
using Mozu.Api.Sample.Models;
using Mozu.Api.Security;
using System.Linq;

namespace Mozu.Api.Sample
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SetEnvironments();
        }

        private ApiContext _apiContext;

        private void SetEnvironments()
        {
            var environments = new List<Models.Environment>();
            environments.Add(new Models.Environment{ Key = "Sandbox", Value="http://sandbox.mozu.com"});
            environments.Add(new Models.Environment { Key = "Production", Value="https://home.mozu.com" });
            
            cbEnvironment.DataSource = environments;
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            try
            {
                var appAuthInfo = new AppAuthInfo { ApplicationId = txtApplicationID.Text, SharedSecret = txtSharedSecret.Text };
                Authentication.Initialize(appAuthInfo,SelectedEnv);

                var userAuthInfo = new UserAuthInfo {EmailAddress = txtEmail.Text, Password = txtPassword.Text};
                UserAuthentication.Initialize(userAuthInfo, SelectedEnv);

                panelTenant.Visible = true;

                cbTenant.DataSource = UserAuthentication.Instance.UserAuthTicket.AvailableTenants;
            }
            catch (ApiException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void AuthValuesChanged(object sender, EventArgs e)
        {
            panelTenant.Visible = false;
            panelAPI.Visible = false;
        }

        private string SelectedEnv
        {
            get { return ((Models.Environment) cbEnvironment.SelectedItem).Value; } 
        }

        private void cbTenant_changed(object sender, EventArgs e)
        {

            cbSite.DataSource = null;
            var tenant = (Tenant)cbTenant.SelectedItem;
            var sites = tenant.SiteGroups.SelectMany(x => x.Sites).ToList();
            cbSite.DataSource = sites;
            cbSite.DisplayMember = "Name";
            panelAPI.Show();
        }

        private void setContext()
        {

            _apiContext = new ApiContext{BaseUrl = SelectedEnv};
            var site = (Site)cbSite.SelectedItem;
            _apiContext.SetContext(site);
            UserAuthentication.Instance.RefreshUserAuthTicket(site.TenantId);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            setContext();
            var orderHome = new OrderHandler.Orders(_apiContext);
            orderHome.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            setContext();
            var productHome = new ProductHandler.Home(_apiContext);
            productHome.Show();
        }


    }
}
