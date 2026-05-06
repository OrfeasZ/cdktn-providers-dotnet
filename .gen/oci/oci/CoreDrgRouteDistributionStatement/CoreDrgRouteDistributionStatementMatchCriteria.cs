using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgRouteDistributionStatement
{
    [JsiiByValue(fqn: "oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteria")]
    public class CoreDrgRouteDistributionStatementMatchCriteria : oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#attachment_type CoreDrgRouteDistributionStatement#attachment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AttachmentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#drg_attachment_id CoreDrgRouteDistributionStatement#drg_attachment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drgAttachmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DrgAttachmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#match_type CoreDrgRouteDistributionStatement#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }
    }
}
