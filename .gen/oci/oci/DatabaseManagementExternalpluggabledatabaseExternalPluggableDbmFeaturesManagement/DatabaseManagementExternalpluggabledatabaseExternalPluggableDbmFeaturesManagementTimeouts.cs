using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementTimeouts")]
    public class DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementTimeouts : oci.DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement.IDatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#create DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#delete DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalpluggabledatabase_external_pluggable_dbm_features_management#update DatabaseManagementExternalpluggabledatabaseExternalPluggableDbmFeaturesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
