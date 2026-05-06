using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementDbManagementPrivateEndpoints
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataOciDatabaseManagementDbManagementPrivateEndpoints.DataOciDatabaseManagementDbManagementPrivateEndpointsFilter")]
    public class DataOciDatabaseManagementDbManagementPrivateEndpointsFilter : oci.DataOciDatabaseManagementDbManagementPrivateEndpoints.IDataOciDatabaseManagementDbManagementPrivateEndpointsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_db_management_private_endpoints#name DataOciDatabaseManagementDbManagementPrivateEndpoints#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_db_management_private_endpoints#values DataOciDatabaseManagementDbManagementPrivateEndpoints#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }

        private object? _regex;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_db_management_private_endpoints#regex DataOciDatabaseManagementDbManagementPrivateEndpoints#regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Regex
        {
            get => _regex;
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
                _regex = value;
            }
        }
    }
}
