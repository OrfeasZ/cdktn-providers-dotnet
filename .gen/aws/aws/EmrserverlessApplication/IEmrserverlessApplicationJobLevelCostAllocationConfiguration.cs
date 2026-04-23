using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationJobLevelCostAllocationConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationJobLevelCostAllocationConfiguration")]
    public interface IEmrserverlessApplicationJobLevelCostAllocationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationJobLevelCostAllocationConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationJobLevelCostAllocationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationJobLevelCostAllocationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
