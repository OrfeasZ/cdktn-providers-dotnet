using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts), fullyQualifiedName: "oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts")]
    public interface IDatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#create DatabasePluggableDatabasePluggabledatabasemanagementsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#delete DatabasePluggableDatabasePluggabledatabasemanagementsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#update DatabasePluggableDatabasePluggabledatabasemanagementsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts), fullyQualifiedName: "oci.databasePluggableDatabasePluggabledatabasemanagementsManagement.DatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabasePluggableDatabasePluggabledatabasemanagementsManagement.IDatabasePluggableDatabasePluggabledatabasemanagementsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#create DatabasePluggableDatabasePluggabledatabasemanagementsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#delete DatabasePluggableDatabasePluggabledatabasemanagementsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_pluggable_database_pluggabledatabasemanagements_management#update DatabasePluggableDatabasePluggabledatabasemanagementsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
