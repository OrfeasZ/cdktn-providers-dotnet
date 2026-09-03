using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiControl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apiaccesscontrolPrivilegedApiControl.ApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct")]
    public class ApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct : oci.ApiaccesscontrolPrivilegedApiControl.IApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/apiaccesscontrol_privileged_api_control#group_id ApiaccesscontrolPrivilegedApiControl#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/apiaccesscontrol_privileged_api_control#group_level ApiaccesscontrolPrivilegedApiControl#group_level}.</summary>
        [JsiiProperty(name: "groupLevel", typeJson: "{\"primitive\":\"number\"}")]
        public double GroupLevel
        {
            get;
            set;
        }
    }
}
