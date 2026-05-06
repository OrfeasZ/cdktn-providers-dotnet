using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails), fullyQualifiedName: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails")]
    public interface IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#is_refreshable_clone DatabasePluggableDatabase#is_refreshable_clone}.</summary>
        [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRefreshableClone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails), fullyQualifiedName: "oci.databasePluggableDatabase.DatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabasePluggableDatabase.IDatabasePluggableDatabasePdbCreationTypeDetailsRefreshableCloneDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database#is_refreshable_clone DatabasePluggableDatabase#is_refreshable_clone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRefreshableClone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRefreshableClone
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
