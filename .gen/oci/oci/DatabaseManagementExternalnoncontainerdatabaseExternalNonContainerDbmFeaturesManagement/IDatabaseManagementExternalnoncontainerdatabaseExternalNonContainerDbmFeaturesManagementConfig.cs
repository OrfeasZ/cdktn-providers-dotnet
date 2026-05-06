using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig), fullyQualifiedName: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig")]
    public interface IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#enable_external_non_container_dbm_feature DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#enable_external_non_container_dbm_feature}.</summary>
        [JsiiProperty(name: "enableExternalNonContainerDbmFeature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableExternalNonContainerDbmFeature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#external_non_container_database_id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#external_non_container_database_id}.</summary>
        [JsiiProperty(name: "externalNonContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalNonContainerDatabaseId
        {
            get;
        }

        /// <summary>feature_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#feature_details DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#feature_details}
        /// </remarks>
        [JsiiProperty(name: "featureDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails? FeatureDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#timeouts DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig), fullyQualifiedName: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#enable_external_non_container_dbm_feature DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#enable_external_non_container_dbm_feature}.</summary>
            [JsiiProperty(name: "enableExternalNonContainerDbmFeature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableExternalNonContainerDbmFeature
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#external_non_container_database_id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#external_non_container_database_id}.</summary>
            [JsiiProperty(name: "externalNonContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalNonContainerDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>feature_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#feature_details DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#feature_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "featureDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails\"}", isOptional: true)]
            public oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails? FeatureDetails
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#id DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#timeouts DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts\"}", isOptional: true)]
            public oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
