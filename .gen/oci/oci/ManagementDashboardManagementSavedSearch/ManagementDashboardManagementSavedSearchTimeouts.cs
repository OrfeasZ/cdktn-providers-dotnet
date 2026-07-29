using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementDashboardManagementSavedSearch
{
    [JsiiByValue(fqn: "oci.managementDashboardManagementSavedSearch.ManagementDashboardManagementSavedSearchTimeouts")]
    public class ManagementDashboardManagementSavedSearchTimeouts : oci.ManagementDashboardManagementSavedSearch.IManagementDashboardManagementSavedSearchTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/management_dashboard_management_saved_search#create ManagementDashboardManagementSavedSearch#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/management_dashboard_management_saved_search#delete ManagementDashboardManagementSavedSearch#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/management_dashboard_management_saved_search#update ManagementDashboardManagementSavedSearch#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
