using System;
using Mozu.Api.Contracts.Customer;
using Mozu.Api.Contracts.ProductAdmin;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using Mozu.Api.Test.Factories;
using System.Net;

namespace Mozu.Api.Test.Helpers
{
    /// <summary>
    /// Class Generator
    /// </summary>
    public class Generator
    {
        public static ServiceClientMessageHandler GetTestClientMessage(int tenantId = 0, int? siteId = null)
        {
            var apiContext = new ApiContext(tenantId, siteId);
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }

        /// <summary>
        /// The _random
        /// </summary>
        private static readonly Random _random = new Random();
        /// <summary>
        /// The alpha chars
        /// </summary>
        private const string AlphaChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// The numeric chars
        /// </summary>
        private const string NumericChars = "0123456789";
        /// <summary>
        /// The alpha numeric chars
        /// </summary>
        private const string AlphaNumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        /// <summary>
        /// The special valid email chars
        /// </summary>
        private const string SpecialValidEmailChars = "-_.";

        /// <summary>
        /// All valid chars
        /// </summary>
        private const string AllValidChars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789,./?;:'*&^%$#@!~` ";

        /// <summary>
        /// Randoms the string.
        /// </summary>
        /// <param name="maxLength">Length of the max.</param>
        /// <param name="characterSet">The character set.</param>
        /// <returns>System.String.</returns>
        public static string RandomString(int maxLength, string characterSet)
        {
            var buffer = new char[maxLength];

            for (var i = 0; i < maxLength; i++)
            {
                buffer[i] = characterSet[_random.Next(characterSet.Length)];
            }

            return new string(buffer);
        }

        /// <summary>
        /// Returns a random boolean value
        /// </summary>
        /// <returns>Random boolean value</returns>
        public static bool RandomBool()
        {
            return (_random.NextDouble() > 0.5);
        }

        /// <summary>
        /// Randoms the string.
        /// </summary>
        /// <param name="maxLength">Length of the max.</param>
        /// <param name="characterGroup">The character group.</param>
        /// <returns>System.String.</returns>
        public static string RandomString(int maxLength, RandomCharacterGroup characterGroup)
        {
            switch (characterGroup)
            {
                case RandomCharacterGroup.AlphaOnly:
                    return RandomString(maxLength, AlphaChars);
                case RandomCharacterGroup.NumericOnly:
                    return RandomString(maxLength, NumericChars);
                case RandomCharacterGroup.AlphaNumericOnly:
                    return RandomString(maxLength, AlphaNumericChars);
                default:
                    return RandomString(maxLength, AllValidChars);

            }

        }

        /// <summary>
        /// Enum RandomCharacterGroup
        /// </summary>
        public enum RandomCharacterGroup
        {
            /// <summary>
            /// The alpha only
            /// </summary>
            AlphaOnly,
            /// <summary>
            /// The numeric only
            /// </summary>
            NumericOnly,
            /// <summary>
            /// The alpha numeric only
            /// </summary>
            AlphaNumericOnly,
            /// <summary>
            /// Any character
            /// </summary>
            AnyCharacter
        }

        /// <summary>
        /// Generates a random Email address using the supplied top level domain.
        /// </summary>
        /// <param name="tld">Top Level Domain (e.g. "com", "net", "org", etc)</param>
        /// <returns>A randomly generated email address with the top level domain passed in.</returns>
        public static string RandomEmailAddress(string tld)
        {
            return string.Format("{0}@{1}.{2}", RandomString(10, RandomCharacterGroup.AlphaOnly),
                                 RandomString(15, RandomCharacterGroup.AlphaNumericOnly), tld);
        }

        /// <summary>
        /// Randoms the email address.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string RandomEmailAddress()
        {
            return string.Format("{0}@{1}.{2}", RandomString(10, RandomCharacterGroup.AlphaOnly),
                                 RandomString(15, RandomCharacterGroup.AlphaNumericOnly), "com");
        }

        /// <summary>
        /// Randoms the day func.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <returns>Func{DateTime}.</returns>
        public static Func<DateTime> RandomDayFunc(DateTime startDate)
        {

            Random gen = new Random();
            var timeSpan = DateTime.Today - startDate;
            {
                int range = ((TimeSpan)timeSpan).Days;

                return () => startDate.AddDays(gen.Next(range));
            }
        }

        /// <summary>
        /// Randoms the type of the customer contact.
        /// </summary>
        /// <returns>CustomerContactType.</returns>
        //public static CustomerContactType RandomCustomerContactType()
        //{
        //    var values = Enum.GetValues(typeof(CustomerContactType));
        //    return (CustomerContactType)values.GetValue(_random.Next((values.Length)));
        //}

        /// <summary>
        /// Randoms the int32.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public static int RandomInt32()
        {
            unchecked
            {
                int firstBits = _random.Next(0, 1 << 4) << 28;
                int lastBits = _random.Next(0, 1 << 28);
                return firstBits | lastBits;
            }
        }

        /// <summary>
        /// Randoms the int32.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public static int RandomInt(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        /// Randoms the decimal.
        /// </summary>
        /// <param name="nonNegative">if set to <c>true</c> [non negative].</param>
        /// <returns>System.Decimal.</returns>
        public static decimal RandomDecimal(bool nonNegative)
        {
            var scale = (byte)_random.Next(29);
            return new decimal(RandomInt32(), RandomInt32(), RandomInt32(), nonNegative, scale);
        }

        /// <summary>
        /// Randoms the decimal.
        /// </summary>
        /// <param name="low">The low.</param>
        /// <param name="mid">The mid.</param>
        /// <param name="high">The high.</param>
        /// <param name="nonNegative">if set to <c>true</c> [non negative].</param>
        /// <returns>System.Decimal.</returns>
        public static decimal RandomDecimal(int low, int mid, int high, bool nonNegative)
        {
            var scale = (byte)_random.Next(29);
            return new decimal(low, mid, high, nonNegative, scale);
        }

        /// <summary>
        /// Random the decimal
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static decimal RandomDecimal(decimal min, decimal max)
        {
            decimal result = Convert.ToDecimal(_random.Next((int)(min*100), (int)(max*100))) / 100;
            return result;
        }



        /// <summary>
        /// Random IP address
        /// </summary>
        /// <returns></returns>
        public static string RandomIPAddress()
        {
            return RandomString(3, RandomCharacterGroup.NumericOnly) + "." +
            RandomString(3, RandomCharacterGroup.NumericOnly) + "." +
            RandomString(3, RandomCharacterGroup.NumericOnly) + "." +
            RandomString(3, RandomCharacterGroup.NumericOnly);
        }

        /// <summary>
        /// Random url
        /// </summary>
        /// <returns></returns>
        public static string RandomURL()
        {
            return "http://" + RandomString(4, RandomCharacterGroup.AlphaNumericOnly) + "/" +
                   RandomString(5, RandomCharacterGroup.AlphaNumericOnly);
        }

        /// <summary>
        /// Random UPC code
        /// </summary>
        /// <returns></returns>
        public static string RandomUPC()
        {
            string upc = "";
            int j;
            for (int i = 0; i < 12; i++)
            {
                j = _random.Next(0, 9)*10 ^ i;
                upc += j.ToString();
            }
            return upc;
        }

        /// <summary>
        /// generate measurement object
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Measurement GenerateMeasurement(string unit, decimal? value)
        {
            return new Mozu.Api.Contracts.Core.Measurement()
            {
                Unit = unit,
                Value = value
            };

        }

        public static Mozu.Api.Contracts.Core.AuditInfo GenerateAuditInfoRandom()
        {
            return new Mozu.Api.Contracts.Core.AuditInfo()
            {
                CreateBy = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                CreateDate = DateTime.Now.AddDays(Generator.RandomInt(-10, -2)),
                UpdateBy = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                UpdateDate = DateTime.Now.AddDays(Generator.RandomInt(-10, -2))
            };
        }

        #region "GenerateCustomerAddress"
        public enum AddressType
        {
            [EnumMember]
            None,
            [EnumMember]
            Residential,
            [EnumMember]
            Commercial,
        }
        /// <summary>
        /// Generates a new Address object using <see cref="Address" /> class.
        /// </summary>
        /// <param name="addr1"></param>
        /// <param name="addr2"></param>
        /// <param name="addr3"></param>
        /// <param name="addr4"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="zip"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Address GenerateAddress(string addr1, string addr2, string addr3, string addr4,
            string city, string country, string zip, string state, AddressType addressType = AddressType.Residential)
        {
            return new Mozu.Api.Contracts.Core.Address()
            {
                Address1 = addr1,
                Address2 = addr2,
                Address3 = addr3,
                Address4 = addr4,
                CountryCode = country,
                CityOrTown = city,
                PostalOrZipCode = zip,
                StateOrProvince = state,
                AddressType = addressType.ToString()
            };
        }


        /// <summary>
        /// Generate Random Address Object.
        /// </summary>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Address GenerateAddressRandom(AddressType addressType = AddressType.Residential)
        {
            return new Mozu.Api.Contracts.Core.Address()
            {
                Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                CountryCode = Generator.RandomString(2, Generator.RandomCharacterGroup.AlphaOnly),
                PostalOrZipCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                StateOrProvince = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                AddressType = addressType.ToString()
            };
        }


        /// <summary>
        /// Generate Address Object with meaningful CountryCode, ZipCode and State
        /// </summary>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Address GenerateAddress(string state, string zip, string country = "US")
        {
            return new Mozu.Api.Contracts.Core.Address()
            {
                Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                CountryCode = country,
                PostalOrZipCode = zip,
                StateOrProvince = state
            };
        }


        public static Mozu.Api.Contracts.Core.Address GenerateInternationalAddress(string country)
        {
            var address = new Mozu.Api.Contracts.Core.Address();
            address.CountryCode = country;
            address.IsValidated = true;
            switch (country)
            {
                case "CA":
                    address.Address1 = "1 Sussex Drive";
                    address.CityOrTown = "Ottawa";
                    address.PostalOrZipCode = "K1A 0A1";
                    address.StateOrProvince = "Ontario";                    
                    break;
                case "GB":
                    address.Address1 = "HARTMANNSTRASSE 7";
                    address.CityOrTown = "BONN";
                    address.PostalOrZipCode = "53001";
                    address.StateOrProvince = "";
                    break;
                case "TW":
                    address.Address1 = "3F #12 LN 410 SEC 2 PA-TEH RD";
                    address.CityOrTown = "TAIPEI";
                    address.PostalOrZipCode = "105";
                    address.StateOrProvince = "";
                    break;
            }
            return (address);
        }


        /// <summary>
        /// Generate Address Object with meaningful CountryCode, ZipCode and State
        /// </summary>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Address GenerateAddress(string state, string zip, bool realAddress = false, string country = "US")
        {
            var address = new Mozu.Api.Contracts.Core.Address();
            address.CountryCode = country;
            address.PostalOrZipCode = zip;
            address.StateOrProvince = state;
            address.IsValidated = true;
            if (realAddress)
            {
                if (state.ToUpper().Equals("TX") && zip.Equals("78717"))
                {
                    address.Address1 = "9900 W. Parmer Lane";
                    address.CityOrTown = "Austin";
                }
                else if (state.ToUpper().Equals("NY") && zip.Equals("11238"))
                {
                    address.Address1 = "950 Fulton St";
                    address.CityOrTown = "Brooklyn";
                }
                else if (state.ToUpper().Equals("NC") && zip.Equals("27601"))
                {
                    address.Address1 = "91 E Edenton St";
                    address.CityOrTown = "Raleigh";
                }
                else if (state.ToUpper().Equals("CA") && zip.Equals("95814"))
                {
                    address.Address1 = "State Capital, Suite 1173";
                    address.CityOrTown = "Sacramento";
                }
                else
                {
                    throw (new TestInconclusiveException(0, System.Reflection.MethodBase.GetCurrentMethod().Name.ToString(CultureInfo.InvariantCulture),
                       null, "No real address found."));
                }
            }
            else
            {
                return new Mozu.Api.Contracts.Core.Address()
                {
                    Address1 =
                        string.Format("{0} {1}",
                                      Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly),
                                      Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                    Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                    Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                    Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                    CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                    CountryCode = country,
                    PostalOrZipCode = zip,
                    StateOrProvince = state
                };
            }
            return address;
        }

        /// <summary>
        /// Generate Random Address Object.
        /// </summary>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Address GenerateAddress(string addressType)
        {
            addressType = addressType.ToUpper();
            AddressType type;

            switch (addressType)
            {
                case "RESIDENTIAL":
                    {
                        type = AddressType.Residential;
                        break;
                    }
                case "COMMERCIAL":
                    {
                        type = AddressType.Commercial;
                        break;
                    }
                case "NONE":
                    {
                        type = AddressType.None;
                        break;
                    }
                default:
                    {
                        //type = AddressType.None;
                        type = AddressType.Residential;

                        break;
                    }
                    break;
            }
            return new Mozu.Api.Contracts.Core.Address()
            {
                Address1 = string.Format("{0} {1}", Generator.RandomString(8, Generator.RandomCharacterGroup.NumericOnly), Generator.RandomString(75, Generator.RandomCharacterGroup.AlphaNumericOnly)),
                Address2 = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                Address3 = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaNumericOnly),
                Address4 = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaNumericOnly),
                CityOrTown = Generator.RandomString(25, Generator.RandomCharacterGroup.AlphaOnly),
                CountryCode = Generator.RandomString(2, Generator.RandomCharacterGroup.AlphaOnly),
                PostalOrZipCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                StateOrProvince = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                AddressType = type.ToString()
            };
        }
    
        #endregion

        #region "GenerateAttribute"

        /// <summary>
        /// Generate Mozu.Api.Contracts.ProductAdmin.AttributeObject
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="valueType"></param>
        /// <param name="dataType"></param>
        /// <param name="isOption"></param>
        /// <param name="isExtra"></param>
        /// <param name="isProperty"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.ProductAdmin.Attribute GenerateAttribute(string inputType = "List", string valueType = "Predefined",
                                                                         string dataType = "String", bool? isOption = false, bool? isExtra = false, bool? isProperty = false)
        {
            return new Mozu.Api.Contracts.ProductAdmin.Attribute
            {
                AttributeCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                AdminName = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly),
                InputType = inputType,
                ValueType = valueType,
                DataType = dataType,
                IsOption = isOption,
                IsExtra = isExtra,
                IsProperty = isProperty,
                Content = GenerateAttributeLocalizedContent(),
                Validation = GenerateAttributeValidation()
            };
        }

        /// <summary>
        /// Generate Mozu.Api.Contracts.ProductAdmin.AttributeObject
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="valueType"></param>
        /// <param name="dataType"></param>
        /// <param name="isOption"></param>
        /// <param name="isExtra"></param>
        /// <param name="isProperty"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.ProductAdmin.Attribute GenerateAttributeSDK(string inputType = "List", string valueType = "Predefined",
                                                                                string dataType = "String", bool? isOption = false, bool? isExtra = false, bool? isProperty = false)
        {
            return new Api.Contracts.ProductAdmin.Attribute
            {
                AttributeCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                AdminName = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly),
                InputType = inputType,
                ValueType = valueType,
                DataType = dataType,
                IsOption = isOption,
                IsExtra = isExtra,
                IsProperty = isProperty,
                Content = GenerateAttributeLocalizedContentSDK(),
                Validation = GenerateAttributeValidationSDK()
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attributeCode"></param>
        /// <param name="adminName"></param>
        /// <param name="inputType"></param>
        /// <param name="valueType"></param>
        /// <param name="dataType"></param>
        /// <param name="isOption"></param>
        /// <param name="isExtra"></param>
        /// <param name="isProperty"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.ProductAdmin.Attribute GenerateAttribute(string attributeCode, string adminName, string inputType = "List", string valueType = "Predefined",
                                                                         string dataType = "String", bool? isOption = false, bool? isExtra = false, bool? isProperty = false)
        {
            var attr = new Mozu.Api.Contracts.ProductAdmin.Attribute
            {
                AttributeCode = attributeCode,
                AdminName = adminName,
                InputType = inputType,
                ValueType = valueType,
                DataType = dataType,
                IsOption = isOption,
                IsExtra = isExtra,
                IsProperty = isProperty,
                AttributeMetadata = new List<AttributeMetadataItem>(),
                Content = GenerateAttributeLocalizedContent(),
                Validation = GenerateAttributeValidation(),
                //                VocabularyValues = new List<AttributeVocabularyValue>()
            };
            attr.AttributeMetadata.Add(GenerateAttributeMetadataItem());
            if (attr.ValueType.ToLower() == "predefined")
            {
                attr.VocabularyValues = new List<AttributeVocabularyValue>
                    {
                        GenerateAttributeVocabularyValueRandom(),
                        GenerateAttributeVocabularyValueRandom()
                    };
            }
            return attr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attributeCode"></param>
        /// <param name="adminName"></param>
        /// <param name="inputType"></param>
        /// <param name="valueType"></param>
        /// <param name="dataType"></param>
        /// <param name="isOption"></param>
        /// <param name="isExtra"></param>
        /// <param name="isProperty"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.ProductAdmin.Attribute GenerateAttributeSDK(string attributeCode, string adminName, string inputType = "List", string valueType = "Predefined",
                                                                                string dataType = "String", bool? isOption = false, bool? isExtra = false, bool? isProperty = false)
        {
            var attr = new Api.Contracts.ProductAdmin.Attribute
            {
                AttributeCode = attributeCode,
                AdminName = adminName,
                InputType = inputType,
                ValueType = valueType,
                DataType = dataType,
                IsOption = isOption,
                IsExtra = isExtra,
                IsProperty = isProperty,
                AttributeMetadata = new List<Api.Contracts.ProductAdmin.AttributeMetadataItem>(),
                Content = GenerateAttributeLocalizedContentSDK(),
                Validation = GenerateAttributeValidationSDK(),
                //                VocabularyValues = new List<AttributeVocabularyValue>()
            };
            attr.AttributeMetadata.Add(GenerateAttributeMetadataItemSDK());
            if (attr.ValueType.ToLower() == "predefined")
            {
                attr.VocabularyValues = new List<Api.Contracts.ProductAdmin.AttributeVocabularyValue>
                    {
                        GenerateAttributeVocabularyValueRandomSDK(),
                        GenerateAttributeVocabularyValueRandomSDK()
                    };
            }
            return attr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.ProductAdmin.Attribute GenerateAttribute(AttributeTypeRule rule)
        {
            var attr = GenerateAttribute();
            attr.InputType = rule.AttributeInputType;
            attr.DataType = rule.AttributeDataType;
            attr.ValueType = rule.AttributeValueType;
            switch (rule.AttributeUsageType.ToLower())
            {
                case "property":
                    attr.IsProperty = true;
                    attr.IsExtra = null;
                    attr.IsOption = null;
                    break;
                case "extra":
                    attr.IsProperty = null;
                    attr.IsExtra = true;
                    attr.IsOption = null;
                    break;
                case "option":
                    attr.IsProperty = null;
                    attr.IsExtra = null;
                    attr.IsOption = true;
                    break;
            }
            return attr;
        }

        /// <summary>
        /// Create an attribute with a list of options
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="attributeName"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.ProductAdmin.Attribute CreateOptionAttribute(ServiceClientMessageHandler handler,
                string attributeName, List<string> values)
        {
            var attr =
                GenerateAttribute(
                    attributeCode:
                        attributeName + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly), isOption: true);
            attr.VocabularyValues.Clear();
            foreach (var value in values)
            {
                attr.VocabularyValues.Add(GenerateAttributeVocabularyValue(value));
            }
            var createdAttr = Mozu.Api.Test.Factories.AttributeFactory.AddAttribute(handler, attr);
            return createdAttr;

        }

        #endregion
        #region "GenerateAttributeInProductType"

        /// <summary>
        /// Generate AttributeInProductType object
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <param name="valueList"></param>
        /// <param name="order"></param>
        /// <param name="isHiddenProperty"></param>
        /// <param name="isInheritedFromBaseType"></param>
        /// <param name="isMultiValueProperty"></param>
        /// <param name="IsRequiredByAdmin"></param>
        /// <returns></returns>
        public static AttributeInProductType GenerateAttributeInProductType(Mozu.Api.Contracts.ProductAdmin.Attribute attr, int? order = null, bool? isHiddenProperty = null, bool? isInheritedFromBaseType = null, bool? isMultiValueProperty = null, bool? IsRequiredByAdmin = null)
        {
            var attrtp = new AttributeInProductType()
            {
                AttributeFQN = attr.AttributeFQN,
                IsHiddenProperty = isHiddenProperty,
                IsInheritedFromBaseType = isInheritedFromBaseType,
                IsMultiValueProperty = isMultiValueProperty,
                IsRequiredByAdmin = IsRequiredByAdmin,
                Order = order,
                //         AttributeDetail = ,
            };
            if (attr.VocabularyValues != null)
            {
                attrtp.VocabularyValues = new List<AttributeVocabularyValueInProductType>();
                foreach (var value in attr.VocabularyValues)
                {
                    attrtp.VocabularyValues.Add(GenerateAttributeVocabularyValueInProductType(value.Value, null));
                }
            }
            return attrtp;
        }

        #endregion
        #region "GenerateAttributeLocalizedContent"

        /// <summary>
        /// generate AttributeLocalizedContent object
        /// </summary>
        /// <param name="localeCode"></param>
        /// <returns></returns>
        public static AttributeLocalizedContent GenerateAttributeLocalizedContent(string localeCode = Constant.LocaleCode)
        {
            return new AttributeLocalizedContent()
            {
                Description = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                LocaleCode = localeCode,
                Name = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly)
            };
        }

        /// <summary>
        /// generate AttributeLocalizedContent object
        /// </summary>
        /// <param name="localeCode"></param>
        /// <returns></returns>
        public static Api.Contracts.ProductAdmin.AttributeLocalizedContent GenerateAttributeLocalizedContentSDK(string localeCode = Constant.LocaleCode)
        {
            return new Api.Contracts.ProductAdmin.AttributeLocalizedContent()
            {
                Description = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                LocaleCode = localeCode,
                Name = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly)
            };
        }

        #endregion
        #region "GenerateAttributeMetaDataItem"

        /// <summary>
        /// generate AttributeMetadataItem object
        /// </summary>
        /// <returns></returns>
        public static AttributeMetadataItem GenerateAttributeMetadataItem()
        {
            return new AttributeMetadataItem()
            {
                Key = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                Value = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly)
            };
        }

        /// <summary>
        /// generate AttributeMetadataItem object
        /// </summary>
        /// <returns></returns>
        public static Api.Contracts.ProductAdmin.AttributeMetadataItem GenerateAttributeMetadataItemSDK()
        {
            return new Api.Contracts.ProductAdmin.AttributeMetadataItem()
            {
                Key = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                Value = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly)
            };
        }

        #endregion
        #region "GenerateAttributeValidation"

        /// <summary>
        /// generate AttributeValidation object
        /// </summary>
        /// <param name="maxDate"></param>
        /// <param name="minDate"></param>
        /// <param name="maxNumeric"></param>
        /// <param name="minNumeric"></param>
        /// <param name="maxStringLen"></param>
        /// <param name="minStringLen"></param>
        /// <returns></returns>
        public static AttributeValidation GenerateAttributeValidation(DateTime? maxDate = null, DateTime? minDate = null, decimal? maxNumeric = null,
                                                                      decimal? minNumeric = null, int? maxStringLen = null, int? minStringLen = null, string expression = null)
        {
            return new AttributeValidation()
            {
                MaxDateValue = maxDate,
                MaxNumericValue = maxNumeric,
                MaxStringLength = maxStringLen,
                MinDateValue = minDate,
                MinNumericValue = minNumeric,
                MinStringLength = minStringLen,
                RegularExpression = expression
            };
        }

        /// <summary>
        /// generate AttributeValidation object
        /// </summary>
        /// <param name="maxDate"></param>
        /// <param name="minDate"></param>
        /// <param name="maxNumeric"></param>
        /// <param name="minNumeric"></param>
        /// <param name="maxStringLen"></param>
        /// <param name="minStringLen"></param>
        /// <returns></returns>
        public static Api.Contracts.ProductAdmin.AttributeValidation GenerateAttributeValidationSDK(DateTime? maxDate = null, DateTime? minDate = null, decimal? maxNumeric = null,
                                                                                                    decimal? minNumeric = null, int? maxStringLen = null, int? minStringLen = null, string expression = null)
        {
            return new Api.Contracts.ProductAdmin.AttributeValidation()
            {
                MaxDateValue = maxDate,
                MaxNumericValue = maxNumeric,
                MaxStringLength = maxStringLen,
                MinDateValue = minDate,
                MinNumericValue = minNumeric,
                MinStringLength = minStringLen,
                RegularExpression = expression
            };
        }

        #endregion
        #region "GenerateAttributeVocabularyValue"

        /// <summary>
        /// generate AttributeVocabularyValue object
        /// </summary>
        /// <returns></returns>
        public static AttributeVocabularyValue GenerateAttributeVocabularyValueRandom()
        {
            return new AttributeVocabularyValue()
            {
                Content = GenerateAttributeVocabularyValueLocalizedContent(Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly)),
                Value = Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly),
                //       ValueSequence = 
            };
        }

        /// <summary>
        /// generate AttributeVocabularyValue object
        /// </summary>
        /// <returns></returns>
        public static Api.Contracts.ProductAdmin.AttributeVocabularyValue GenerateAttributeVocabularyValueRandomSDK()
        {
            return new Api.Contracts.ProductAdmin.AttributeVocabularyValue()
            {
                Content = GenerateAttributeVocabularyValueLocalizedContentSdk(Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly)),
                Value = Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly),
                //       ValueSequence = 
            };
        }

        /// <summary>
        /// generate AttributeVocabularyValue object
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AttributeVocabularyValue GenerateAttributeVocabularyValue(string value)
        {
            return new AttributeVocabularyValue()
            {
                Content = GenerateAttributeVocabularyValueLocalizedContent(Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly)),
                Value = value
            };
        }

        #endregion
        #region "GenerateAttributeVocabularyValueInProductType"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static AttributeVocabularyValueInProductType GenerateAttributeVocabularyValueInProductType(object value, int? order = 0)
        {
            return new AttributeVocabularyValueInProductType()
            {
                Value = value,
                Order = order
            };
        }

        #endregion
        #region "GenerateAttributeVocabularyValueLocalizedContent"

        /// <summary>
        /// generate AttributeVocabularyValueLocalizedContent object
        /// </summary>
        /// <param name="stringValue"></param>
        /// <param name="localeCode"></param>
        /// <returns></returns>
        public static AttributeVocabularyValueLocalizedContent GenerateAttributeVocabularyValueLocalizedContent(string stringValue = null, string localeCode = Constant.LocaleCode)
        {
            return new AttributeVocabularyValueLocalizedContent()
            {
                LocaleCode = localeCode,
                StringValue = stringValue
            };
        }

        /// <summary>
        /// generate AttributeVocabularyValueLocalizedContent object
        /// </summary>
        /// <param name="stringValue"></param>
        /// <param name="localeCode"></param>
        /// <returns></returns>
        public static Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent GenerateAttributeVocabularyValueLocalizedContentSdk(string stringValue = null, string localeCode = Constant.LocaleCode)
        {
            return new Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent()
            {
                LocaleCode = localeCode,
                StringValue = stringValue
            };
        }

        #endregion

        #region "GenerateCategory"

        /// <summary>
        /// generate Category object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isDisplayed"></param>
        /// <param name="parentCategoryId"></param>
        /// <returns></returns>
        public static Category GenerateCategory(string name, bool? isDisplayed = true, int? parentCategoryId = null)
        {
            return new Category()
            {
                Content = GenerateCategoryLocalizedContent(name),
                IsDisplayed = isDisplayed,
                ParentCategoryId = parentCategoryId,
            };
        }

        #endregion
        #region "GenerateCategoryLocalizedContent"

        /// <summary>
        /// generate CategoryLocalizedContent object
        /// </summary>
        /// <param name="localeCode"></param>
        /// <returns></returns>
        public static CategoryLocalizedContent GenerateCategoryLocalizedContent(string name = null, string localeCode = Constant.LocaleCode)
        {
            return new CategoryLocalizedContent()
            {
                Description = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                LocaleCode = localeCode,
                MetaTagDescription = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                MetaTagKeywords = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                MetaTagTitle = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly),
                Name = name,
                PageTitle = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                Slug = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
            };
        }

        #endregion
        #region "GenerateContact" 

        public static Mozu.Api.Contracts.Core.Contact GenerateContact()
        {
            return new Mozu.Api.Contracts.Core.Contact
                {
                    Address = Generator.GenerateAddressRandom(),
                    CompanyOrOrganization = Generator.RandomString(50, Generator.RandomCharacterGroup.AlphaNumericOnly),
                    Email = Generator.RandomEmailAddress(),
                    FirstName = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                    MiddleNameOrInitial = Generator.RandomString(1, Generator.RandomCharacterGroup.AlphaOnly),
                    LastNameOrSurname = Generator.RandomString(35, Generator.RandomCharacterGroup.AlphaOnly),
                    PhoneNumbers = Generator.GeneratePhoneRandom()
                };
        }

        #endregion
        #region "GenerateCustomerAccount"

        /// <summary>
        /// Generate Customer Account
        /// </summary>
        /// <param name="taxExempt"></param>
        /// <param name="taxId"></param>
        /// <returns></returns>
        public static CustomerAccountAndAuthInfo GenerateCustomerAccountAndAuthInfo(bool taxExempt = false, string taxId = null)
        {
            var customer = new CustomerAccount()
                {
                    AcceptsMarketing = false,
                    CompanyOrOrganization = "Volusion",
                    Contacts = new List<CustomerContact>() { GenerateCustomerContact(0, GenerateAddressRandom(addressType: AddressType.Residential)) },
                    EmailAddress = Generator.RandomEmailAddress(),
                    FirstName = Generator.RandomString(10, RandomCharacterGroup.AlphaOnly),
                    LastName = Generator.RandomString(10, RandomCharacterGroup.AlphaOnly),
                    UserName = Generator.RandomString(10, RandomCharacterGroup.AlphaOnly),
                    TaxExempt = taxExempt,
                    TaxId = taxId,
                    LocaleCode = Constant.LocaleCode,
                    Notes = new List<CustomerNote>() { GenerateCustomerNote()}
                };

            var customerAccountAndAuthInfo = new CustomerAccountAndAuthInfo
                {
                    Account = customer,
                    Password = Constant.Password
                };

            return customerAccountAndAuthInfo;
        }
        /// <summary>
        /// Generate Random Customer Note
        /// </summary>
        /// <returns></returns>
        public static CustomerNote GenerateCustomerNote()
        {
            return new CustomerNote()
                {
                    Content = Generator.RandomString(maxLength: 25, characterGroup: RandomCharacterGroup.AnyCharacter)
                };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static CustomerAccount GenerateCustomerAccount(string userId)
        {
            return new CustomerAccount()
            {
                UserId = userId,
                CompanyOrOrganization = "Volusion"
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static CustomerAccount GenerateCustomerAccount(string userId, CustomerContact item)
        {
            return new CustomerAccount()
            {
                UserId = userId,
                Contacts = new List<CustomerContact>() { item }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="companyOrOrganization"></param>
        /// <param name="commerceSummary"></param>
        /// <param name="item"></param>
        /// <param name="groups"></param>
        /// <param name="attributes"></param>
        /// <param name="notes"></param>
        /// <param name="acceptsMarketing"></param>
        /// <param name="taxExempt"></param>
        /// <returns></returns>
        public static CustomerAccount GenerateCustomerAccount(string userId, string companyOrOrganization, CommerceSummary commerceSummary,
            CustomerContact item, List<Mozu.Api.Contracts.Customer.CustomerGroup> groups, List<CustomerAttribute> attributes, List<CustomerNote> notes, bool acceptsMarketing,
            bool taxExempt)
        {
            return new CustomerAccount()
            {
                UserId = userId,
                CommerceSummary = commerceSummary,
                CompanyOrOrganization = companyOrOrganization,
                Contacts = new List<CustomerContact>() { item },
                Groups = groups,
                Attributes = attributes,
                Notes = notes,
                AcceptsMarketing = acceptsMarketing,
                TaxExempt = taxExempt
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalOrderAmount"></param>
        /// <param name="orderCount"></param>
        /// <param name="wishlistCount"></param>
        /// <param name="lastOrderDate"></param>
        /// <returns></returns>
        public static CommerceSummary GenerateCommerceSummary(decimal totalOrderAmount, int orderCount,
                                                              int wishlistCount, DateTime? lastOrderDate = null)
        {
            var amount = new CurrencyAmount
                {
                    Amount = totalOrderAmount,
                    CurrencyCode = "USD"
                };
            return new CommerceSummary()
            {
                TotalOrderAmount = amount,
                OrderCount = orderCount,
                WishlistCount = wishlistCount,
                LastOrderDate = lastOrderDate
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalOrderAmount"></param>
        /// <param name="orderCount"></param>
        /// <param name="wishlistCount"></param>
        /// <param name="lastOrderDate"></param>
        /// <returns></returns>
        public static CommerceSummary GenerateCommerceSummary(CurrencyAmount totalOrderAmount, int orderCount,
                                                              int wishlistCount, DateTime? lastOrderDate = null)
        {
            return new CommerceSummary()
            {
                TotalOrderAmount = totalOrderAmount,
                OrderCount = orderCount,
                WishlistCount = wishlistCount,
                LastOrderDate = lastOrderDate
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="currencyCode"></param>
        /// <returns></returns>
        public static CurrencyAmount GenerateCurrencyAmount(decimal amount, string currencyCode)
        {
            return new CurrencyAmount()
            {
                Amount = amount,
                CurrencyCode = currencyCode
            };
        }
        #endregion
        #region "GenerateCustomerContact"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="id"></param>
        /// <param name="lastname"></param>
        /// <param name="middlename"></param>
        /// <param name="company"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="types"></param>
        /// <returns></returns>
        public static CustomerContact GenerateCustomerContact(int accountId, string email, string firstname,
                                                              int id, string lastname, string middlename, string company,
                                                              Mozu.Api.Contracts.Core.Address address, Mozu.Api.Contracts.Core.Phone phone)
        {
            return new CustomerContact()
            {
                AccountId = accountId,
                Email = email,
                FirstName = firstname,
                Id = id,
                LastNameOrSurname = lastname,
                MiddleNameOrInitial = middlename,
                CompanyOrOrganization = company,
                Address = address,
                PhoneNumbers = phone
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="numContacts"></param>
        /// <returns></returns>
        public static List<CustomerContact> GenerateCustomerContactsRandom(int accountId, int numContacts)
        {
            var contacts = new List<CustomerContact>();
            for (int i = 0; i < numContacts; i++)
            {
                var contact = GenerateCustomerContact(accountId);
                contacts.Add(contact);
            }
            return contacts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static CustomerContact GenerateCustomerContact(int accountId)
        {
            return new CustomerContact()
            {
                AccountId = accountId,
                Email = Generator.RandomEmailAddress(),
                FirstName = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                Id = Generator.RandomInt(4, 10),
                LastNameOrSurname = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                MiddleNameOrInitial = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                CompanyOrOrganization = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaOnly),
                Address = GenerateAddressRandom(),
                PhoneNumbers = GeneratePhoneRandom()

            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static CustomerContact GenerateCustomerContact(int accountId, Mozu.Api.Contracts.Core.Address address)
        {
            return new CustomerContact()
            {
                AccountId = accountId,
                Email = Generator.RandomEmailAddress(),
                FirstName = Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly),
                Id = Generator.RandomInt(4, 10),
                LastNameOrSurname = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                MiddleNameOrInitial = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                CompanyOrOrganization = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaOnly),
                Address = address,
                PhoneNumbers = GeneratePhoneRandom()

            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="lastnameorsurname"></param>
        /// <returns></returns>
        public static CustomerContact GenerateCustomerContact(int accountId, string email, string firstname,
                                                              string lastnameorsurname)
        {
            return new CustomerContact()
            {
                AccountId = accountId,
                Email = email,
                FirstName = firstname,
                Id = Generator.RandomInt(4, 10),
                LastNameOrSurname = lastnameorsurname,
                MiddleNameOrInitial = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                CompanyOrOrganization = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaOnly),
                Address = GenerateAddressRandom(),
                PhoneNumbers = GeneratePhoneRandom()

            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public static CustomerContact GenerateCustomerContact(int accountId, string firstname)
        {
            return new CustomerContact()
            {
                AccountId = accountId,
                Email = Generator.RandomEmailAddress(),
                FirstName = firstname,
                Id = Generator.RandomInt(4, 10),
                LastNameOrSurname = Generator.RandomString(15, Generator.RandomCharacterGroup.AlphaOnly),
                MiddleNameOrInitial = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                CompanyOrOrganization = Generator.RandomString(20, Generator.RandomCharacterGroup.AlphaOnly),
                Address = GenerateAddressRandom(),
                PhoneNumbers = GeneratePhoneRandom()

            };
        }

        #endregion
        #region "GeneratePhone"
        /// <summary>
        /// Generates a new Phone object using <see cref="Generator" /> class.
        /// </summary>
        /// <param name="home"></param>
        /// <param name="mobile"></param>
        /// <param name="work"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Phone GeneratePhone(string home, string mobile, string work)
        {
            return new Mozu.Api.Contracts.Core.Phone()
            {
                Home = home,
                Mobile = mobile,
                Work = work
            };
        }


        /// <summary>
        /// Generates a new Phone object using <see cref="Generator" /> class.
        /// </summary>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.Phone GeneratePhoneRandom()
        {
            return new Mozu.Api.Contracts.Core.Phone()
            {
                Home = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                 Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                 Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                Mobile = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                 Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                 Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly)),
                Work = string.Format("{0}-{1}-{2}", Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                 Generator.RandomString(3, Generator.RandomCharacterGroup.NumericOnly),
                                 Generator.RandomString(4, Generator.RandomCharacterGroup.NumericOnly))
            };
        }
        #endregion

        #region "GenerateProduct"

        /// <summary>
        /// generate Product object
        /// </summary>
        /// <param name="productTypeId"> producttype id. If null, it will use the default one</param>
        /// <param name="extras"></param>
        /// <param name="options"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        public static Product GenerateProduct(int? productTypeId = null,
                                                                     List<ProductExtra> extras = null,
                                                                     List<ProductOption> options = null,
                                                                     List<ProductProperty> properties = null)
        {
            Product PTobj;
            PTobj = new Product()
            {
                ProductCode = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                Price = GenerateProductPrice(price: Generator.RandomDecimal(50, 200)),
                //SeoContent = GenerateProductLocalizedSEOContent(),
                Content = GenerateProductLocalizedContent(Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly)),
                Extras = extras,
                Options = options,
                Properties = properties,
                ProductTypeId = productTypeId,
                PackageWeight = GenerateMeasurement("lbs", Generator.RandomDecimal(50, 200))
                //                   ProductInSites = ,
                //                   UPC = ,
                //                   IsHiddenWhenOutOfStock = ,
                //                   IsBackOrderAllowed = ,
                //                    IsPackagedStandAlone = ,
                //                    IsTaxable = ,
                //                    ManageStock = ,
                //                    StockOnHandAdjustment = ,
                //                    IsRecurring = ,
                //                    StandAlonePackageType = ,
                //                    PackageHeight = ,
                //                    PackageLength = ,
                //                    PackageWidth = ,
                //the following are readonly
                //                    ApplicableDiscounts = ,
                //                    StockAvailable = ,
                //                    StockOnBackOrder = ,
                //                    StockOnHand = ,
                //                    ShippingClassId = ,
                //                    IsValidForProductType = ,
                //                    ProductSequence = ,
                //                    SiteGroupId = ,
                //                    HasConfigurableOptions = ,
                //                    HasStandAloneOptions = ,
                //                    AuditInfo = ,
                //                    BaseProductCode = ,                    
                //                    IsVariation = ,
                //                    VariationKey = ,
                //                    VariationOptions = 
            };
            return PTobj;
        }

        /// <summary>
        /// generate product object
        /// </summary>
        /// <param name="productType"></param>
        /// <returns></returns>
        public static Product GenerateProduct(ProductType productType)
        {
            List<string> attributeFQNs = new List<string>();
            List<ProductExtra> extras = null;
            List<ProductProperty> properties = null;
            List<ProductOption> options = null;
            if (productType.Extras != null)
            {
                foreach (var extra in productType.Extras)
                {
                    if (!attributeFQNs.Contains(extra.AttributeFQN))
                    {
                        if (extras == null)
                            extras = new List<ProductExtra>();
                        extras.Add(GenerateProductExtra(extra));
                        attributeFQNs.Add(extra.AttributeFQN);
                    }
                }
            }
            if (productType.Properties != null)
            {
                foreach (var property in productType.Properties)
                {
                    if (!attributeFQNs.Contains(property.AttributeFQN))
                    {
                        if (properties == null)
                            properties = new List<ProductProperty>();
                        properties.Add(GenerateProductProperty(property));
                        attributeFQNs.Add(property.AttributeFQN);
                    }
                }
            }
            if (productType.Options != null)
            {
                foreach (var option in productType.Options)
                {
                    if (!attributeFQNs.Contains(option.AttributeFQN))
                    {
                        if (options == null)
                            options = new List<ProductOption>();
                        options.Add(GenerateProductOption(option));
                        attributeFQNs.Add(option.AttributeFQN);
                    }
                }
            }
            return GenerateProduct(productType.Id, extras, options, properties);
        }

        /// <summary>
        /// generate product object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="salep"></param>
        /// <param name="stock"></param>
        /// <param name="productType"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public static Product GenerateProduct(string name, decimal price,
                                                                     decimal salep, int stock, ProductType productType,
                                                                     decimal weight)
        {
            var pd = GenerateProduct(productType);
            pd.Content.ProductName = name;
            pd.Price = GenerateProductPrice(price: price, salePrice: salep);
            pd.PackageWeight = GenerateMeasurement("lbs", weight);
            return pd;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="salep"></param>
        /// <param name="stock"></param>
        /// <param name="productType"></param>
        /// <param name="weight"></param>
        /// <param name="unit"></param>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="standAlonePkgType"></param>
        /// <param name="productTypeId"></param>
        /// <param name="pkgStandAlone"></param>
        /// <param name="taxable"></param>
        /// <param name="mgmtStock"></param>
        /// <param name="recurring"></param>
        /// <returns></returns>
        public static Product GenerateProduct(string productCode, string name, decimal? price,
                                                                     decimal? salep, int stock, decimal weight,
                                                                     string unit, int height, int length, int width,
                                                                     string standAlonePkgType,
                                                                     int? productTypeId = 1,
                                                                     bool? pkgStandAlone = false, bool? taxable = true,
                                                                     bool? mgmtStock = true, bool? recurring = false)
        {
            var pd = GenerateProduct(productTypeId);
            pd.ProductCode = productCode;
            pd.Content.ProductName = name;
            pd.Price = GenerateProductPrice(price: price, salePrice: salep);
            pd.IsPackagedStandAlone = pkgStandAlone;
            pd.IsTaxable = taxable;
            pd.InventoryInfo.ManageStock = mgmtStock;
            //            pd.StockOnHandAdjustment = stockAdjustment;
            pd.IsRecurring = recurring;
            pd.StandAlonePackageType = standAlonePkgType;
            pd.PackageHeight = GenerateMeasurement(unit, height);
            pd.PackageLength = GenerateMeasurement(unit, length);
            pd.PackageWidth = GenerateMeasurement(unit, width);
            pd.PackageWeight = GenerateMeasurement("lbs", weight);
            return pd;
        }

        #endregion
        #region "GenerateProductCategory"

        /// <summary>
        /// generate ProductCategory object
        /// </summary>
        /// <param name="cateId"></param>
        /// <returns></returns>
        public static ProductCategory GenerateProductCategory(int cateId)
        {
            return new ProductCategory()
            {
                CategoryId = cateId
            };
        }

        public static List<ProductCategory> GenerateProductCategoryList(List<int> cateIds)
        {
            return cateIds.Select(cat => new ProductCategory() { CategoryId = cat }).ToList();
        }

        #endregion

        #region "GenerateProductPrice"

        /// <summary>
        /// generate ProductPrice object
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="price"></param>
        /// <param name="salePrice"></param>
        /// <returns></returns>
        public static ProductPrice GenerateProductPrice(string currency = Constant.Currency, decimal? price = null, decimal? salePrice = null)
        {
            return new ProductPrice
            {
                IsoCurrencyCode = currency,
                Price = price,
                SalePrice = salePrice
            };
        }

        #endregion
        #region "GenerateProductExtra"

        /// <summary>
        /// generate ProductExtra object
        /// </summary>
        /// <param name="attributeInProductType"></param>
        /// <param name="isMultiSelect"></param>
        /// <param name="isRequired"></param>
        /// <returns></returns>
        public static ProductExtra GenerateProductExtra(AttributeInProductType attributeInProductType, bool? isMultiSelect = null, bool? isRequired = null)
        {
            var extra = new ProductExtra()
            {
                AttributeFQN = attributeInProductType.AttributeFQN,
                IsMultiSelect = isMultiSelect,
                IsRequired = isRequired
            };
            if (attributeInProductType.VocabularyValues != null)
            {
                foreach (var value in attributeInProductType.VocabularyValues)
                {
                    if (extra.Values == null)
                    {
                        extra.Values = new List<ProductExtraValue>();
                    }
                    extra.Values.Add(GenerateProductExtraValue(Generator.RandomDecimal(10, 20),
                                                                       value.Value, null, null));
                    //if (attr.IsMultiValueProperty != null && attr.IsMultiValueProperty == false)
                    //    break;
                }
            }
            return extra;
        }

        #endregion
        #region "GenerateProductExtraValue"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="value"></param>
        /// <param name="weight"></param>
        /// <param name="isDefault"></param>
        /// <returns></returns>
        public static ProductExtraValue GenerateProductExtraValue(decimal price, object value, decimal? weight, bool? isDefault)
        {
            return new ProductExtraValue()
            {
                DeltaPrice = GenerateProductExtraValueDeltaPrice(price),
                Value = value,
                DeltaWeight = weight,
                IsDefaulted = isDefault
            };
        }

        #endregion
        #region "GenerateProductExtraValueDeltaPrice"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static ProductExtraValueDeltaPrice GenerateProductExtraValueDeltaPrice(decimal price, string currency = Constant.Currency)
        {
            return new ProductExtraValueDeltaPrice()
            {
                CurrencyCode = currency,
                DeltaPrice = price
            };
        }

        #endregion
        #region "GenerateProductInCatalogInfo"

        /// <summary>
        /// generate ProductInSiteInfo object
        /// </summary>
        /// <param name="siteId"></param>
        /// <param name="productCategories"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="isActive"></param>
        /// <param name="isContentOverridden"></param>
        /// <param name="isPriceOverridden"></param>
        /// <param name="isSeoContentOverridden"></param>
        /// <returns></returns>
        public static ProductInCatalogInfo GenerateProductInCatalogInfo(int catalogId, List<ProductCategory> productCategories, string name, decimal? price, bool? isActive,
                                                                  bool? isContentOverridden, bool? isPriceOverridden, bool? isSeoContentOverridden)
        {
            return new ProductInCatalogInfo
            {
                Content = GenerateProductLocalizedContent(name),
                //SeoContent = GenerateProductLocalizedSEOContent(),
                IsActive = isActive,
                IsContentOverridden = isContentOverridden,
                IsPriceOverridden = isPriceOverridden,
                //IsseoContentOverridden = isSeoContentOverridden,
                Price = GenerateProductPrice(price: price),
                ProductCategories = productCategories,
                CatalogId = catalogId,
            };
        }

        /// <summary>
        /// generate ProductInSiteInfo object
        /// </summary>
        /// <param name="siteId"></param>
        /// <param name="cateId"></param>
        /// <param name="isActive"></param>
        /// <param name="isContentOverridden"></param>
        /// <param name="isPriceOverridden"></param>
        /// <param name="isSeoContentOverridden"></param>
        /// <returns></returns>
        public static ProductInCatalogInfo GenerateProductInCatalogInfo(int siteId, int? cateId, bool? isActive = true,
                                                                  bool? isContentOverridden = true, bool? isPriceOverridden = true, bool? isSeoContentOverridden = true)
        {
            var info = GenerateProductInCatalogInfo(siteId, null, Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly), 
                Generator.RandomDecimal(10, 100), isActive, isContentOverridden, isPriceOverridden, isSeoContentOverridden);
            if (cateId.HasValue)
            {
                info.ProductCategories = new List<ProductCategory>(){new ProductCategory(){CategoryId = cateId.Value}}; 
            }
            return info;
        }

        #endregion
        #region "GenerateProductLocalizedContent"

        /// <summary>
        /// Generate ProductLocalizedContent object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="imageList"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static ProductLocalizedContent GenerateProductLocalizedContent(string name,
                                                                                                     List<ProductLocalizedImage> imageList = null, string locale = Constant.LocaleCode)
        {
            return new ProductLocalizedContent
            {
                LocaleCode = locale,
                ProductFullDescription = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                ProductImages = imageList,
                ProductName = name,
                ProductShortDescription = Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly),
            };
        }

        #endregion
        #region "GenerateProductLocalizedImage"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="videoUrl"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static ProductLocalizedImage GenerateProductLocalizedImage(string imageUrl, string videoUrl, string locale = Constant.LocaleCode)
        {
            return new ProductLocalizedImage()
            {
                AltText = Generator.RandomString(6, Generator.RandomCharacterGroup.AlphaOnly),
                ImageLabel = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                //ImagePath = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly) + "/" + Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly),
                ImageUrl = imageUrl,
                LocaleCode = locale,
                VideoUrl = videoUrl
            };
        }

        #endregion
        #region "GenerateProductLocalizedSEOContent"

        /// <summary>
        /// generate ProductLocalizedSEOContent object
        /// </summary>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static ProductLocalizedSEOContent GenerateProductLocalizedSEOContent(string locale = Constant.LocaleCode)
        {
            return new ProductLocalizedSEOContent
            {
                LocaleCode = locale,
                MetaTagDescription = Generator.RandomString(10, Generator.RandomCharacterGroup.AlphaOnly),
                MetaTagKeywords = Generator.RandomString(4, Generator.RandomCharacterGroup.AlphaOnly),
                MetaTagTitle = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                //SeoFriendlyUrl = Generator.RandomURL(),
                TitleTagTitle = Generator.RandomString(8, Generator.RandomCharacterGroup.AlphaOnly)
            };
        }

        #endregion

        #region "GenerateProductOption"

        /// <summary>
        /// generate ProductOption object
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public static ProductOption GenerateProductOption(AttributeInProductType attr)
        {
            var option = new ProductOption()
            {
                AttributeFQN = attr.AttributeFQN
            };
            if (attr.VocabularyValues != null)
            {
                foreach (var value in attr.VocabularyValues)
                {
                    if (option.Values == null)
                    {
                        option.Values = new List<ProductOptionValue>();
                    }
                    option.Values.Add(GenerateProductOptionValue(value.Value));
                    //if (attr.IsMultiValueProperty != null && attr.IsMultiValueProperty == false)
                    //    break;
                }
            }
            return option;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attr"></param>
        /// <param name="valueCount"></param>
        /// <returns></returns>
        public static ProductOption GenerateProductOption(AttributeInProductType attr, int valueCount)
        {
            var option = new ProductOption()
            {
                AttributeFQN = attr.AttributeFQN
            };
            if (attr.VocabularyValues != null)
            {
                int count = 0;
                foreach (var value in attr.VocabularyValues)
                {
                    if (option.Values == null)
                    {
                        option.Values = new List<ProductOptionValue>();
                    }
                    option.Values.Add(GenerateProductOptionValue(value.Value));
                    count++;
                    if (count == valueCount)
                        break;
                }
            }
            return option;
        }

        #endregion
        #region "GenerateProductOptionValue"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ProductOptionValue GenerateProductOptionValue(object value)
        {
            return new ProductOptionValue()
            {
                Value = value
            };
        }

        #endregion
        #region "GenerateProductProperty"

        /// <summary>
        /// generate ProductProperty
        /// </summary>
        /// <param name="attributeFQN"></param>
        /// <returns></returns>
        public static ProductProperty GenerateProductProperty(AttributeInProductType attr)
        {
            var property = new ProductProperty()
            {
                AttributeFQN = attr.AttributeFQN
            };
            if (attr.VocabularyValues != null)
            {
                foreach (var value in attr.VocabularyValues)
                {
                    if (property.Values == null)
                    {
                        property.Values = new List<ProductPropertyValue>();
                    }
                    property.Values.Add(GenerateProductPropertyValue(value.Value,
                                                                     GenerateProductPropertyValueLocalizedContent(
                                                                         Generator.RandomString(5,
                                                                                                Generator.RandomCharacterGroup.AlphaOnly))));
                    if (attr.IsMultiValueProperty != null && attr.IsMultiValueProperty == false)
                        break;
                }
            }
            return property;
        }

        #endregion
        #region "GenerateProductPropertyValue"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static ProductPropertyValue GenerateProductPropertyValue(object value, ProductPropertyValueLocalizedContent content)
        {
            return new ProductPropertyValue()
            {
                Value = value,
                Content = content
            };
        }

        #endregion
        #region "GenerateProductPropertyValueLocalizedContent"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public static ProductPropertyValueLocalizedContent GenerateProductPropertyValueLocalizedContent(string value, string locale = Constant.LocaleCode)
        {
            return new ProductPropertyValueLocalizedContent()
            {
                LocaleCode = locale,
                StringValue = value
            };
        }

        #endregion
        #region "GenerateProductReservation"

        public static ProductReservation GenerateProductReservation(string locCode, string orderId, string orderItemId, string productCode, int quantity)
        {
            return new ProductReservation()
            {
                LocationCode = locCode,
                OrderId = orderId,
                OrderItemId = orderItemId,
                ProductCode = productCode,
                Quantity = quantity
            };
        }

        #endregion
        #region "GenerateProductType"

        /// <summary>
        /// Generate ProductType object
        /// </summary>
        /// <param name="options"></param>
        /// <param name="properties"></param>
        /// <param name="extras"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ProductType GenerateProductType(string name, List<AttributeInProductType> options = null,
                                                                             List<AttributeInProductType> properties = null, List<AttributeInProductType> extras = null)
        {
            return new ProductType()
            {
                Name = name,
                Options = options,
                Properties = properties,
                Extras = extras,
                //                AuditInfo = 
                //                SiteGroupId = 
                //                Id = 
                //                IsBaseProductType = 
            };
        }

        /// <summary>
        /// Generate a producttype from one attribute
        /// </summary>
        /// <param name="attr"></param>
        /// <param name="name"> producttype name </param>
        /// <returns></returns>
        public static ProductType GenerateProductType(Mozu.Api.Contracts.ProductAdmin.Attribute attr, string name)
        {
            var attrs = new List<Mozu.Api.Contracts.ProductAdmin.Attribute> { attr };
            return GenerateProductType(attrs, name: name);
        }

        /// <summary>
        /// Generate product type
        /// </summary>
        /// <param name="attrs"> Mozu.Api.Contracts.ProductAdmin.Attributelist used in producttype </param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ProductType GenerateProductType(List<Mozu.Api.Contracts.ProductAdmin.Attribute> attrs,
                                                                             string name)
        {
            List<AttributeInProductType> extras = null;
            List<AttributeInProductType> properties = null;
            List<AttributeInProductType> options = null;
            foreach (var attr in attrs)
            {
                var attrInPT = GenerateAttributeInProductType(attr);
                if (attr.IsOption.HasValue)
                {
                    if ((bool)attr.IsOption)
                    {
                        if (options == null)
                            options = new List<AttributeInProductType>();
                        options.Add(attrInPT);
                    }
                }

                if (attr.IsExtra.HasValue)
                {
                    if ((bool)attr.IsExtra)
                    {
                        if (extras == null)
                            extras = new List<AttributeInProductType>();
                        extras.Add(attrInPT);
                    }
                }

                if (attr.IsProperty.HasValue)
                {
                    if ((bool)attr.IsProperty)
                    {
                        if (properties == null)
                        {
                            properties = new List<AttributeInProductType>();
                        }
                        attrInPT.IsMultiValueProperty = true;
                        properties.Add(attrInPT);
                    }
                }
            }
            return GenerateProductType(name, options, properties, extras);
        }

        #endregion
        #region "GenerateProductVariationDeltaPrice"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ProductVariationDeltaPrice GenerateProductVariationDeltaPrice(decimal value)
        {
            return new ProductVariationDeltaPrice()
            {
                CurrencyCode = Constant.Currency,
                Value = value
            };
        }

        #endregion
        #region "GenerateProductVarationCollection

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static ProductVariationCollection GenerateProductVariationCollection(List<ProductVariation> items, long totalCount)
        {
            return new ProductVariationCollection()
            {
                Items = items,
                TotalCount = totalCount
            };
        }

        #endregion
        #region "GenerateStandAlonePackageTypeConst"
        public static string GenerateStandAlonePackageTypeConst()
        {
            string type = null;
            int i = Generator.RandomInt(1, 7);
            switch (i)
            {
                case 1:
                    type = StandAlonePackageTypeConst.CARRIER_BOX_LARGE;
                    break;
                case 2:
                    type = StandAlonePackageTypeConst.CARRIER_BOX_MEDIUM;
                    break;
                case 3:
                    type = StandAlonePackageTypeConst.CARRIER_BOX_SMALL;
                    break;
                case 4:
                    type = StandAlonePackageTypeConst.CUSTOM;
                    break;
                case 5:
                    type = StandAlonePackageTypeConst.LETTER;
                    break;
                case 6:
                    type = StandAlonePackageTypeConst.PAK;
                    break;
                case 7:
                    type = StandAlonePackageTypeConst.TUBE;
                    break;
            }
            return type;
        }

        public static class StandAlonePackageTypeConst
            {
              public const string TUBE = "TUBE";
              public const string LETTER = "LETTER";
              public const string PAK = "PAK";
              public const string CARRIER_BOX_SMALL = "CARRIER_BOX_SMALL";
              public const string CARRIER_BOX_MEDIUM = "CARRIER_BOX_MEDIUM";
              public const string CARRIER_BOX_LARGE = "CARRIER_BOX_LARGE";
              public const string CUSTOM = "CUSTOM";
            }
        #endregion

        #region "GenerateUser"
        /// <summary>
        /// Generate User object
        /// </summary>
        /// <param name="isActive"></param>
        /// <param name="password"></param>
        /// <param name="localecode"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.User GenerateUser(bool isActive = true, string password = Constant.Password, string localecode = Constant.LocaleCode)
        {
            return new Mozu.Api.Contracts.Core.User
            {
                //EmailAddress = "mozuqa@volusion.com",
                //EmailAddress = "paultesting43@volusion.com",
                EmailAddress = Generator.RandomEmailAddress(),
                FirstName = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                LastName = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                IsActive = isActive,
                LocaleCode = localecode,
                Password = password
            };
        }

        /// <summary>
        /// Generate User object
        /// </summary>
        /// <param name="random"></param>
        /// <param name="localecode"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.User GenerateUser(bool random, string localecode = Constant.LocaleCode)
        {
            return new Mozu.Api.Contracts.Core.User
            {
                EmailAddress = Generator.RandomEmailAddress(),
                FirstName = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                LastName = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                IsActive = true,
                LocaleCode = localecode,
                Password = Constant.Password
            };
        }

        /// <summary>
        /// Generates a new User object.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="isActive"></param>
        /// <param name="password"></param>
        /// <param name="localecode"></param>
        /// <returns>Mozu.Core.Api.Contracts.User</returns>
        public static Mozu.Api.Contracts.Core.User GenerateUser(string email, bool isActive = true, string password = Constant.Password, string localecode = Constant.LocaleCode)
        {
            return new Mozu.Api.Contracts.Core.User
            {
                EmailAddress = email,
                FirstName = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                LastName = Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                IsActive = isActive,
                LocaleCode = localecode,
                Password = password,
            };
        }

        public static Mozu.Api.Contracts.Core.User GenerateUser(string email, string name)
        {
            var names = name.Split(' ');
            return new Mozu.Api.Contracts.Core.User
            {
                EmailAddress = email,
                FirstName = names.First(),
                LastName = names.Last(),
                IsActive = true,
                LocaleCode = Constant.LocaleCode,
                Password = Constant.Password,
            };
        }
        public static Mozu.Api.Contracts.Core.User GenerateUser(string email, string firstName, string lastName)
        {
            return new Mozu.Api.Contracts.Core.User
            {
                EmailAddress = email,
                FirstName = firstName,
                LastName = lastName,
                IsActive = true,
                LocaleCode = Constant.LocaleCode,
                Password = Constant.Password,
            };
        }
        #endregion
        #region GenerateUserAuthInfo

        /// <summary>
        /// Generate UserAuthInfo Object.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        public static Mozu.Api.Contracts.Core.UserAuthInfo GenerateUserAuthInfo(string email, string passwd = "MozuPass1")
        {
            if (string.IsNullOrEmpty(email))
                email = Generator.RandomEmailAddress();

            return new Mozu.Api.Contracts.Core.UserAuthInfo()
            {
                EmailAddress = email,
                Password = passwd
            };
        }
        #endregion
        #region GenerateCustomerAuthInfo

        /// <summary>
        /// Generate CustomerUserAuthInfo Object.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        public static CustomerUserAuthInfo GenerateCustomerUserAuthInfo(string userName, string passwd = "MozuPass1")
        {
            if (string.IsNullOrEmpty(userName))
                userName = Generator.RandomString(15, RandomCharacterGroup.AlphaNumericOnly);

            return new CustomerUserAuthInfo()
            {
                Username = userName,
                Password = passwd
            };
        }
        #endregion
        #region "PopulateSampleSite"

        /// <summary>
        /// populate 10 attributes, 3 product types and 13 product to a sitegroup
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="masterCatalogId"></param>
        public static void PopulateProductsToMasterCatalog(int tenantId, int masterCatalogId)
        {
            var ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId);

            //create color attribute
            var createdColor = AttributeFactory.AddAttribute(ApiMsgHandler, GenerateAttribute(
                    attributeCode: "Color_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Color_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    isOption: true));

            //create upgrade attribute (shopper entered)
            var createdUpgrade = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute(
                    attributeCode: "Upgrade_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Upgrade_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    inputType: "TextBox", valueType: "ShopperEntered", isExtra: true));

            //create rating attribute (admin entered)
            var createdRating = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute( attributeCode: "Rating_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Rating_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    inputType: "TextBox", valueType: "AdminEntered", dataType: "Number", isProperty: true));

            //create size attribute
            var createdSize = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute( attributeCode: "Size_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Size_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    isProperty: true));

            //create monogram attribute (shopper entered)
            var createdMonogram = AttributeFactory.AddAttribute(ApiMsgHandler, GenerateAttribute(attributeCode: "Monogram_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Monogram_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    inputType: "TextBox", valueType: "ShopperEntered", isExtra: true));

            //create brand attribute
            var createdBrand = AttributeFactory.AddAttribute(ApiMsgHandler, GenerateAttribute( attributeCode: "Brand_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Brand_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    isExtra: true));

            //create fabric attribute
            var createdFabric = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute( attributeCode: "Fabric_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Fabric_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    isProperty: true));

            //create furniture material attribute
            var createdMaterial = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute( attributeCode: "Material_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Material_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    isProperty: true));

            //create created date attribute (admin entered)
            var createdDiscountExpire = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute( attributeCode:
                        "DiscountExpire_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "DiscountExpire_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    inputType: "DateTime", valueType: "AdminEntered", dataType: "datetime", isProperty: true));

            //create warranty attribute (shopper entered)
            var createdWarranty = AttributeFactory.AddAttribute(ApiMsgHandler,GenerateAttribute( attributeCode: "Warranty_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    adminName: "Warranty_" + Generator.RandomString(5, Generator.RandomCharacterGroup.AlphaOnly),
                    inputType: "YesNo", valueType: "ShopperEntered", dataType: "Bool", isExtra: true));

            //create product type for furnitures (size, color, fabric, brand, material) 
            var furniturePT =
                Generator.GenerateProductType(
                    new List<Mozu.Api.Contracts.ProductAdmin.Attribute>()
                        {
                            createdSize,
                            createdFabric,
                            createdBrand,
                            createdMaterial
                        }, "Furniture");
            //ProductType furniturePT = Product.GenerateProductType(new List<Attribute>(){createdSize, createdColor, createdFabric, createdBrand, createdMaterial}, "Furniture");
            var createdFurniturePT = ProductTypeFactory.AddProductType(ApiMsgHandler, furniturePT);

            //create product type for shoes (size, color, discountExpire)
            var shoePT =
                Generator.GenerateProductType(
                    new List<Mozu.Api.Contracts.ProductAdmin.Attribute>() { createdColor, createdDiscountExpire }, "Shoe");
            var createdShoePT = ProductTypeFactory.AddProductType(ApiMsgHandler, shoePT);

            //create product type for hats (size, color, monogram, upgrade)
            var hatPT =
                Generator.GenerateProductType(
                    new List<Mozu.Api.Contracts.ProductAdmin.Attribute>() { createdSize, createdMonogram, createdUpgrade },
                    "Hat");
            var createdHatPT = ProductTypeFactory.AddProductType(ApiMsgHandler, hatPT);

            //create sofas (Cangy, Walsh, Amani, Burton)
            var createdCangy = ProductFactory.AddProduct(ApiMsgHandler,
                                          GenerateProduct("Cagny Sofa", 2000, 1800, 1000, createdFurniturePT, 60));
            var createdWalsh = ProductFactory.AddProduct(ApiMsgHandler,
                                          GenerateProduct("Walsh Sofa", 3000, 2900, 1000, createdFurniturePT, 70));
            var createdAmani = ProductFactory.AddProduct(ApiMsgHandler,
                                          GenerateProduct("Amani Sofa", 1200, 999, 5000, createdFurniturePT, 55));
            var createdBurton = ProductFactory.AddProduct(ApiMsgHandler,
                                           GenerateProduct("Burton Sofa", 1500, 1350, 8000, createdFurniturePT,
                                                                   68));

            //create tables (Wooden, Plastic)
            var createdCangyWoodTbl = ProductFactory.AddProduct(ApiMsgHandler,
                                                 GenerateProduct("Cagny Wood Table", 500, 450, 1000,
                                                                         createdFurniturePT, 50));
            var createdCangyPlasticTbl = ProductFactory.AddProduct(ApiMsgHandler,
                                                    GenerateProduct("Amani Plastic Table", 250, 180, 9000,
                                                                            createdFurniturePT, 30));

            //create different kinds of shoes (Flats, Sandals, HighHeels)
            var createdFlats = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("Flats", 18, 15, 6500, createdShoePT, 10));
            ActivateVariations(ApiMsgHandler, createdFlats);
            var createdSandals = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("Sandals", 20, 15, 8000, createdShoePT, 2));
            ActivateVariations(ApiMsgHandler, createdSandals);
            var createdHighHeels = ProductFactory.AddProduct(ApiMsgHandler,
                                              GenerateProduct("HighHeels", 28, 25, 5500, createdShoePT, 5));
            ActivateVariations(ApiMsgHandler, createdHighHeels);

            //create different knids of hats (Cowboy, Baseball, Straw, Newsboys)
            var createdCowboy = ProductFactory.AddProduct(ApiMsgHandler,
                                           GenerateProduct("Cowboy Hat", 10, 8, 1200, createdHatPT, 2));
            var createdBaseball = ProductFactory.AddProduct(ApiMsgHandler,
                                             GenerateProduct("Baseball Hat", 18, 12, 8500, createdHatPT, 8));
            var createdStraw = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("Straw Hat", 18, 15, 7500, createdHatPT, 2));
            var createdNewsboy = ProductFactory.AddProduct(ApiMsgHandler,
                                            GenerateProduct("Newsboy Hat", 12, 8, 1100, createdHatPT, 10));
        }

        /// <summary>
        /// add 13 products to a site and associate with categories
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="masterCatalogId"></param>
        /// <param name="catalogId"></param>
        public static void PopulateProductsToCatalog(int tenantId, int masterCatalogId, int catalogId)
        {
            PopulateProductsToMasterCatalog(tenantId, masterCatalogId);
            var ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId);

            var products = ProductFactory.GetProducts(ApiMsgHandler,filter:null,noCount:null,q:null,qLimit:null,startIndex:null, pageSize: 13, sortBy: "ProductSequence desc");
            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId, catalogId:catalogId); 
            // create categories

            //     cate1         cate2          cate3
            //     /   \            |         /   |   \
            //   c1_1  c1_2        3ps      c3_1 c3_2 c3_3
            //    |     |                   /  \       |   
            //   2ps    3ps            c3_1_1  c3_1_2  rest
            //                            |       |
            //                           2ps     1ps

            var cate1 = CategoryFactory.AddCategory(ApiMsgHandler, Generator.GenerateCategory("cate1"));
            var cate2 = CategoryFactory.AddCategory(ApiMsgHandler, Generator.GenerateCategory("cate2"));
            var cate3 = CategoryFactory.AddCategory(ApiMsgHandler, Generator.GenerateCategory("cate3"));

            var cate1_1 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                         Generator.GenerateCategory("c1_1", parentCategoryId: cate1.Id));
            var cate1_2 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                         Generator.GenerateCategory("c1_2", parentCategoryId: cate1.Id));

            var cate3_1 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                         Generator.GenerateCategory("c3_1", parentCategoryId: cate3.Id));
            var cate3_2 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                         Generator.GenerateCategory("c3_2", parentCategoryId: cate3.Id));
            var cate3_3 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                         Generator.GenerateCategory("c3_3", parentCategoryId: cate3.Id));

            var cate3_1_1 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                           Generator.GenerateCategory("c3_1_1",
                                                                                     parentCategoryId: cate3_1.Id));
            var cate3_1_2 = CategoryFactory.AddCategory(ApiMsgHandler,
                                                           Generator.GenerateCategory("c3_1_2",
                                                                                     parentCategoryId: cate3_1.Id));

            // Assoicate products with categories
            int i = 0;
            var proCate = new ProductCategory();
            foreach (var product in products.Items)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                        proCate.CategoryId = cate1_1.Id.Value;
                        break;
                    case 2:
                    case 3:
                    case 4:
                        proCate.CategoryId = cate1_2.Id.Value;
                        break;
                    case 5:
                    case 6:
                    case 7:
                        proCate.CategoryId = cate2.Id.Value;
                        break;
                    case 8:
                    case 9:
                        proCate.CategoryId = cate3_1_1.Id.Value;
                        break;
                    case 10:
                        proCate.CategoryId = cate3_1_2.Id.Value;
                        break;
                    case 11:
                    case 12:
                        proCate.CategoryId = cate3_3.Id.Value;
                        break;
                }

                var proInfo = GenerateProductInCatalogInfo(catalogId, productCategories: new List<ProductCategory>() { proCate },
                                                            name: Generator.RandomString(6,Generator.RandomCharacterGroup.AlphaOnly),
                                                            price: Generator.RandomDecimal(20, 1000), 
                                                            isActive: true, 
                                                            isPriceOverridden: true,
                                                            isSeoContentOverridden: false, 
                                                            isContentOverridden: true);

                ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: proInfo,productCode: product.ProductCode);
                i++;
            }
        }

        public static void ActivateVariations(ServiceClientMessageHandler messageHandler,
                                              Product product)
        {
            var vars = ProductTypeVariationFactory.GenerateProductVariations(messageHandler,productOptionsIn: product.Options,
                                                        productTypeId: (int)product.ProductTypeId);
            foreach (var variation in vars.Items)
            {
                variation.IsActive = true;
                variation.DeltaPrice =
                    GenerateProductVariationDeltaPrice(Generator.RandomDecimal(0,
                                                                                       (decimal)
                                                                                       (product.Price.Price - 1)));
                variation.DeltaWeight = Generator.RandomDecimal(0, (decimal)(product.PackageWeight.Value - 1));
                ProductVariationFactory.UpdateProductVariation(messageHandler,productVariation: variation,productCode: product.ProductCode, variationKey:
                                                        variation.Variationkey);
            }
        }


        public static void PopulateProductsToSiteForDiscounts(int tenantId, int masterCatalogId, int catalogId)
        {
            PopulateProductsToSitegrp1(tenantId, masterCatalogId);
            var ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId);

            var products = ProductFactory.GetProducts(ApiMsgHandler,filter:null,noCount:null,q:null,startIndex:null,qLimit:null, pageSize: 25, sortBy: "ProductSequence desc");

            ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId, catalogId:catalogId);

            var living = CategoryFactory.AddCategory(ApiMsgHandler, Generator.GenerateCategory("Living"));
            var dining = CategoryFactory.AddCategory(ApiMsgHandler, Generator.GenerateCategory("Dining"));

            //associate products to categories
            int cateId = 0;
            ProductInCatalogInfo proInfo = null;
            foreach (var product in products.Items)
            {
                switch (product.ProductCode)
                {
                    case "artichoke-dining-lamp":
                        cateId = living.Id.Value;
                        break;
                    case "case-study-sofa-bed":
                        cateId = living.Id.Value;
                        break;
                    case "helix-coffee-table":
                        cateId = living.Id.Value;
                        break;
                    case "metropolitan-chair":
                        cateId = living.Id.Value;
                        break;
                    case "nelson-coconut-chair":
                        cateId = living.Id.Value;
                        break;
                    case "ph-floor-lamp":
                        cateId = living.Id.Value;
                        break;
                    case "raleigh-sofa":
                        cateId = living.Id.Value;
                        break;
                    case "skagen-coffee-table":
                        cateId = living.Id.Value;
                        break;
                    case "bantam-sofa":
                        cateId = living.Id.Value;
                        break;
                    case "tripod-lamp":
                        cateId = living.Id.Value;
                        break;
                    case "cellula-dining-chandelier":
                        cateId = dining.Id.Value;
                        break;
                    case "cherner-dining-table":
                        cateId = dining.Id.Value;
                        break;
                    case "lancaster-dining-table":
                        cateId = dining.Id.Value;
                        break;
                    case "lancaster-dining-chair":
                        cateId = dining.Id.Value;
                        break;
                    case "lancaster_barstool":
                        cateId = dining.Id.Value;
                        break;
                    case "eames-dining-chair":
                        cateId = dining.Id.Value;
                        break;
                    case "fucsia-dining-lamp":
                        cateId = dining.Id.Value;
                        break;
                    case "profile-dining-chair":
                        cateId = dining.Id.Value;
                        break;
                    case "bottega-dining-chair":
                        cateId = dining.Id.Value;
                        break;
                    case "lc6-dining-table":
                        cateId = dining.Id.Value;
                        break;
                }
                proInfo = GenerateProductInCatalogInfo(catalogId, cateId, true, true, false, true);
                ProductFactory.AddProductInCatalog(handler: ApiMsgHandler,productInCatalogInfoIn: proInfo,productCode: product.ProductCode);
            }
            var proInSite = ProductFactory.GetProductInCatalog(handler: ApiMsgHandler,productCode: "artichoke-dining-lamp",catalogId: catalogId, expectedCode: (int)HttpStatusCode.OK);
            var prodCates = new List<ProductCategory>(); 
            prodCates.Add(proInSite.ProductCategories[0]);
            prodCates.Add(GenerateProductCategory(dining.Id.Value));
            proInfo = GenerateProductInCatalogInfo(catalogId: catalogId,
                                                     productCategories: prodCates, 
                                                     name: proInSite.Content.ProductName, 
                                                     price: proInSite.Price.Price, 
                                                     isActive: proInSite.IsActive,
                                                     isContentOverridden: proInSite.IsContentOverridden, 
                                                     isPriceOverridden: proInSite.IsPriceOverridden,
                                                     isSeoContentOverridden: proInSite.IsseoContentOverridden
                                                     );
            ProductFactory.UpdateProductInCatalog(handler: ApiMsgHandler,
                                        productInCatalogInfoIn: proInfo, 
                                        productCode: "artichoke-dining-lamp", 
                                        catalogId: catalogId, successCode:
                                        (int)HttpStatusCode.OK);
        }


        public static void PopulateProductsToSitegrp1(int tenantId, int masterCatalogId)
        {
            var ApiMsgHandler = ServiceClientMessageFactory.GetTestClientMessage(tenantId, masterCatalogId: masterCatalogId);
            var pts = ProductTypeFactory.GetProductTypes(handler: ApiMsgHandler,pageSize:null,sortBy:null,startIndex:null, filter: "Name eq Base");

            //create products using base producttype (10 for living room)
            var createdArtichokeLamp = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("artichoke-dining-lamp", "Artichoke Lamp", 10260, 9999, 30, Convert.ToDecimal(15), "in", 10, 10, 10, "", pts.Items[0].Id));
            var createdSofaBed = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("case-study-sofa-bed", "Case Study Sofa Bed", 1895, null, 50, Convert.ToDecimal(70), "in", 27, 80, 33, "", pts.Items[0].Id));
            var createdHelixTable = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("helix-coffee-table", "Helix Coffee Table", 2200, 2100, 50, Convert.ToDecimal(40), "in", 16, 53, 35, "", pts.Items[0].Id));
            var createdMetropolitanChair = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("metropolitan-chair", "Metropolitan Chair", 3550, null, 65, Convert.ToDecimal(68), "in", 38, 40, 33, "", pts.Items[0].Id));
            var createdNelsonChair = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("nelson-coconut-chair", "Nelson Coconut Chair", 1900, 1750, 90, Convert.ToDecimal(30), "in", 33, 34, 40, "", pts.Items[0].Id));
            var createdPHLamp = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("ph-floor-lamp", "PH Floor Lamp", 1596, null, 250, Convert.ToDecimal(15), "in", 51, 10, 13, "", pts.Items[0].Id));
            var createdRaleighSofa = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("raleigh-sofa", "Raleigh Sofa", 6630, null, 50, Convert.ToDecimal(70), "in", 34, 85, 35, "", pts.Items[0].Id));
            var createdSkagenTable = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("skagen-coffee-table", "Skagen Coffee Table", 1260, null, 200, Convert.ToDecimal(42), "in", 17, 50, 20, "", pts.Items[0].Id));
            var createdBantamSofa = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("bantam-sofa", "Bantam Sofa", 6630, null, 50, Convert.ToDecimal(70), "in", 32, 87, 36, "", pts.Items[0].Id));
            var createdTripodLamp = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("tripod-lamp", "Tripod Lamp", 395, null, 200, Convert.ToDecimal(35), "in", 68, 22, 22, "", pts.Items[0].Id));

            //create products using base producttype (10 for dining room)
            var createdCellulaChandelier = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("cellula-dining-chandelier", "Cellula Dining Chandelier", 5995, 5000, 25, Convert.ToDecimal(15), "in", 12, 36, 9, "", pts.Items[0].Id));
            var createdChernerTable = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("cherner-dining-table", "Cherner Dining Table", 135, 100, 200, Convert.ToDecimal(20), "in", 30, 72, 34, "", pts.Items[0].Id));
            var createdLancasterTable = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("lancaster-dining-table", "Lancaster Dining Table", 2245, null, 45, Convert.ToDecimal(57), "in", 30, 48, 48, "", pts.Items[0].Id));
            var createdLancasterChair = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("lancaster-dining-chair", "Lancaster Dining Chair", 575, null, 500, Convert.ToDecimal(18), "in", 30, 20, 18, "", pts.Items[0].Id));
            var createdLancasterStool = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("lancaster_barstool", "Lancaster Barstool", 650, null, 1000, Convert.ToDecimal(15), "in", 43, 22, 18, "", pts.Items[0].Id));
            var createdEamesChair = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("eames-dining-chair", "Eames Dining Chair", 160, 130, 900, Convert.ToDecimal(15), "in", 29, 22, 19, "", pts.Items[0].Id));
            var createdFucsiaLamp = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("fucsia-dining-lamp", "Fucsia Dining Lamp", 2545, null, 30, Convert.ToDecimal(15), "in", 13, 6, 3, "", pts.Items[0].Id));
            var createdProfileChair = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("profile-dining-chair", "Profile Dining Chair", 499, 399, 900, Convert.ToDecimal(15), "in", 30, 18, 20, "", pts.Items[0].Id));
            var createdBottegaChair = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("bottega-dining-chair", "Bottega Dining Chair", 865, null, 80, Convert.ToDecimal(20), "in", 37, 22, 24, "", pts.Items[0].Id));
            var createdLC6Table = ProductFactory.AddProduct(ApiMsgHandler, GenerateProduct("lc6-dining-table", "LC6 Dining Table", 2590, null, 45, Convert.ToDecimal(55), "in", 29, 89, 34, "", pts.Items[0].Id));
        }


        public static void RestoreQuantitiesForFurnitureProducts(ServiceClientMessageHandler handler)
        {
            Dictionary<string, int> products = new Dictionary<string, int>
                { { "artichoke-dining-lamp", 30 }, { "case-study-sofa-bed", 50 }, { "helix-coffee-table", 50 }, { "metropolitan-chair", 65 }, 
            { "nelson-coconut-chair", 90 }, { "ph-floor-lamp", 250 }, { "raleigh-sofa", 50 }, { "skagen-coffee-table", 200 }, { "bantam-sofa", 50 }, { "tripod-lamp", 200 }, { "cellula-dining-chandelier", 25 }, 
            { "cherner-dining-table", 200 }, { "lancaster-dining-table", 45 }, { "lancaster-dining-chair", 500 }, { "lancaster_barstool", 1000 }, { "eames-dining-chair", 900 }, { "fucsia-dining-lamp", 30 }, 
            { "profile-dining-chair", 900 }, { "bottega-dining-chair", 80 }, { "lc6-dining-table", 45 } };
            foreach (var p in products)
            {
                //var stock = new StockOnHandAdjustment { Type = "Absolute", Value = p.Value };
                //var updateProductStock = UpdateProductStock(handler, stock, p.Key);   TODO Esther
            }
        }


        public static void RestoreQuantitiesForOldSiteProducts(ServiceClientMessageHandler handler)
        {
            Dictionary<string, int> products = new Dictionary<string, int>
                { { "Cagny Sofa", 100 }, { "Walsh Sofa", 10 }, { "Amani Sofa", 50 }, { "Burton Sofa", 80 }, { "Cagny Wood Table" , 100 }, 
            { "Amani Plastic Table", 90 }, { "Flats", 65 }, { "Sandals", 80 }, { "HighHeels", 55 }, { "Cowboy Hat", 120 }, { "Baseball Hat", 85 }, { "Straw Hat", 75 }, { "Newsboy Hat", 110 } };
            foreach (var p in products)
            {
               // var stock = new StockOnHandAdjustment { Type = "Absolute", Value = p.Value };
               // var getProducts = GetProducts(handler, 0, 1, null, null, "Content.ProductName eq \"" + p.Key + "\"");
                //var updateProductStock = UpdateProductStock(handler, stock, getProducts.Items[0].ProductCode);         TODO Esther
            }
        }


        public static void RestoreProductPrice(ServiceClientMessageHandler handler, string productCode, decimal price, decimal? saleprice = null)
        {
            var getProduct = ProductFactory.GetProduct(handler, productCode);
            getProduct.Price.Price = price;
            getProduct.Price.SalePrice = saleprice;
            var updateProduct = ProductFactory.UpdateProduct(handler,product: getProduct, productCode: getProduct.ProductCode);
        }


        public static void RestoreProductStock(ServiceClientMessageHandler handler, string productCode, int quantity)
        {
           // var stock = new StockOnHandAdjustment { Type = "Absolute", Value = quantity };
            //var updateProductStock = UpdateProductStock(handler, stock, productCode);      TODO Esther
        }
        #endregion

    }
}