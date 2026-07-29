using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiControl
{
    [JsiiInterface(nativeType: typeof(IApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiControl.ApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct")]
    public interface IApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/apiaccesscontrol_privileged_api_control#group_id ApiaccesscontrolPrivilegedApiControl#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] GroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/apiaccesscontrol_privileged_api_control#group_level ApiaccesscontrolPrivilegedApiControl#group_level}.</summary>
        [JsiiProperty(name: "groupLevel", typeJson: "{\"primitive\":\"number\"}")]
        double GroupLevel
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiControl.ApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.ApiaccesscontrolPrivilegedApiControl.IApiaccesscontrolPrivilegedApiControlApproverGroupLevelListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/apiaccesscontrol_privileged_api_control#group_id ApiaccesscontrolPrivilegedApiControl#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] GroupId
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/apiaccesscontrol_privileged_api_control#group_level ApiaccesscontrolPrivilegedApiControl#group_level}.</summary>
            [JsiiProperty(name: "groupLevel", typeJson: "{\"primitive\":\"number\"}")]
            public double GroupLevel
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
