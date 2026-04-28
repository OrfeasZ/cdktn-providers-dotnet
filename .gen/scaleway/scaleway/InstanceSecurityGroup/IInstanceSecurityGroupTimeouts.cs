using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroup
{
    [JsiiInterface(nativeType: typeof(IInstanceSecurityGroupTimeouts), fullyQualifiedName: "scaleway.instanceSecurityGroup.InstanceSecurityGroupTimeouts")]
    public interface IInstanceSecurityGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#default InstanceSecurityGroup#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceSecurityGroupTimeouts), fullyQualifiedName: "scaleway.instanceSecurityGroup.InstanceSecurityGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceSecurityGroup.IInstanceSecurityGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#default InstanceSecurityGroup#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
