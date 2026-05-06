using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabase
{
    [JsiiByValue(fqn: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails")]
    public class DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails : oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails
    {
        private object? _isRefreshableClone;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#is_refreshable_clone DatabasePluggableDatabase#is_refreshable_clone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRefreshableClone
        {
            get => _isRefreshableClone;
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
                _isRefreshableClone = value;
            }
        }
    }
}
