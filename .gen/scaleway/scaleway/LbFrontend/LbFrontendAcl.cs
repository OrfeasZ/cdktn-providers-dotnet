using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lbFrontend.LbFrontendAcl")]
    public class LbFrontendAcl : scaleway.LbFrontend.ILbFrontendAcl
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#action LbFrontend#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclAction\"}")]
        public scaleway.LbFrontend.ILbFrontendAclAction Action
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#match LbFrontend#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclMatch\"}")]
        public scaleway.LbFrontend.ILbFrontendAclMatch Match
        {
            get;
            set;
        }

        /// <summary>Description of the ACL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#description LbFrontend#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>The ACL name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#name LbFrontend#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
