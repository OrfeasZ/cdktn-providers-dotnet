using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructureStorage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExadataInfrastructureStorage.DatabaseExadataInfrastructureStorageContacts")]
    public class DatabaseExadataInfrastructureStorageContacts : oci.DatabaseExadataInfrastructureStorage.IDatabaseExadataInfrastructureStorageContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_storage#email DatabaseExadataInfrastructureStorage#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public string Email
        {
            get;
            set;
        }

        private object _isPrimary;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_storage#is_primary DatabaseExadataInfrastructureStorage#is_primary}.</summary>
        [JsiiProperty(name: "isPrimary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsPrimary
        {
            get => _isPrimary;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPrimary = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_storage#name DatabaseExadataInfrastructureStorage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _isContactMosValidated;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_storage#is_contact_mos_validated DatabaseExadataInfrastructureStorage#is_contact_mos_validated}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isContactMosValidated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsContactMosValidated
        {
            get => _isContactMosValidated;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isContactMosValidated = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_storage#phone_number DatabaseExadataInfrastructureStorage#phone_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhoneNumber
        {
            get;
            set;
        }
    }
}
