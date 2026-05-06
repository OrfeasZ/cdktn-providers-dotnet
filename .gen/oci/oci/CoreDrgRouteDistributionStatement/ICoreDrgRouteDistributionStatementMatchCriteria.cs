using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgRouteDistributionStatement
{
    [JsiiInterface(nativeType: typeof(ICoreDrgRouteDistributionStatementMatchCriteria), fullyQualifiedName: "oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteria")]
    public interface ICoreDrgRouteDistributionStatementMatchCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#attachment_type CoreDrgRouteDistributionStatement#attachment_type}.</summary>
        [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AttachmentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#drg_attachment_id CoreDrgRouteDistributionStatement#drg_attachment_id}.</summary>
        [JsiiProperty(name: "drgAttachmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DrgAttachmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#match_type CoreDrgRouteDistributionStatement#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDrgRouteDistributionStatementMatchCriteria), fullyQualifiedName: "oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteria")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#attachment_type CoreDrgRouteDistributionStatement#attachment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AttachmentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#drg_attachment_id CoreDrgRouteDistributionStatement#drg_attachment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drgAttachmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DrgAttachmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_route_distribution_statement#match_type CoreDrgRouteDistributionStatement#match_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
