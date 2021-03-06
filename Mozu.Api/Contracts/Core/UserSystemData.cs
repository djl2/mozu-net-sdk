
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Core
{
		///
		///	System-supplied and read-only information about the user.
		///
		public class UserSystemData
		{
			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime? CreatedOn { get; set; }

			///
			///The number of failed authentication attempts associated with the user.
			///
			public byte FailedLoginAttemptCount { get; set; }

			///
			///The date and time the initial login was unsuccessful, which is system-supplied and read only. Each time user authentication fails, an update occurs on this field.
			///
			public DateTime? FirstFailedLoginAttemptOn { get; set; }

			///
			///If true, the user account is locked due to multiple failed authentication attempts.
			///
			public bool IsLocked { get; set; }

			///
			///If true, the login requires a password change for increased security. If false, the login does not require a password change.
			///
			public bool IsPasswordChangeRequired { get; set; }

			///
			///When the user's account was last locked. System-supplied and read-only.
			///
			public DateTime? LastLockedOn { get; set; }

			///
			/// When the user last logged into the store. System-supplied and read-only.
			///
			public DateTime? LastLoginOn { get; set; }

			///
			/// When the password was last modified. System-supplied and read-only.
			///
			public DateTime? LastPasswordChangeOn { get; set; }

			///
			///The number of login attempts left for the user. The user must login successfully before this value reaches zero otherwise the account will be locked.
			///
			public int RemainingLoginAttempts { get; set; }

			///
			///Date and time when the entity was last updated, represented in UTC Date/Time.
			///
			public DateTime? UpdatedOn { get; set; }

		}

}