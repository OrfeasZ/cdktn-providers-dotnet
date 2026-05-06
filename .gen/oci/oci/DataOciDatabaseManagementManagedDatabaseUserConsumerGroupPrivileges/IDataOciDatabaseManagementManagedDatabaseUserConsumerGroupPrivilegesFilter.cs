using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivilegesFilter), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges.DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivilegesFilter")]
    public interface IDataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivilegesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user_consumer_group_privileges#name DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user_consumer_group_privileges#values DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user_consumer_group_privileges#regex DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivilegesFilter), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges.DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivilegesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges.IDataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivilegesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user_consumer_group_privileges#name DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user_consumer_group_privileges#values DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user_consumer_group_privileges#regex DataOciDatabaseManagementManagedDatabaseUserConsumerGroupPrivileges#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
