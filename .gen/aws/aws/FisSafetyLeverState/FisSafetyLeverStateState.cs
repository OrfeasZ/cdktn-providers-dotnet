using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisSafetyLeverState
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fisSafetyLeverState.FisSafetyLeverStateState")]
    public class FisSafetyLeverStateState : aws.FisSafetyLeverState.IFisSafetyLeverStateState
    {
        /// <summary>Reason for the current status of the safety lever.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/fis_safety_lever_state#reason FisSafetyLeverState#reason}
        /// </remarks>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public string Reason
        {
            get;
            set;
        }

        /// <summary>State of the safety lever. Valid values: engaged, disengaged.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/fis_safety_lever_state#status FisSafetyLeverState#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
