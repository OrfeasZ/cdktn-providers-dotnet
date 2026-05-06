using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails), fullyQualifiedName: "oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails")]
    public interface IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#feature DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        string Feature
        {
            get;
        }

        /// <summary>connector_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#connector_details DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#connector_details}
        /// </remarks>
        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails), fullyQualifiedName: "oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#feature DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#feature}.</summary>
            [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
            public string Feature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>connector_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#connector_details DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#connector_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
            public oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementFeatureDetailsConnectorDetails?>();
            }
        }
    }
}
