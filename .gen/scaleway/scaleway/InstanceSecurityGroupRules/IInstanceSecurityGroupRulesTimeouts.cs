using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroupRules
{
    [JsiiInterface(nativeType: typeof(IInstanceSecurityGroupRulesTimeouts), fullyQualifiedName: "scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesTimeouts")]
    public interface IInstanceSecurityGroupRulesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#default InstanceSecurityGroupRules#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceSecurityGroupRulesTimeouts), fullyQualifiedName: "scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#default InstanceSecurityGroupRules#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
