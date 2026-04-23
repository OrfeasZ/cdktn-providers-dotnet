using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiInterface(nativeType: typeof(IEksCapabilityConfigurationArgoCdAwsIdc), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfigurationArgoCdAwsIdc")]
    public interface IEksCapabilityConfigurationArgoCdAwsIdc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#idc_instance_arn EksCapability#idc_instance_arn}.</summary>
        [JsiiProperty(name: "idcInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string IdcInstanceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#idc_region EksCapability#idc_region}.</summary>
        [JsiiProperty(name: "idcRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdcRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksCapabilityConfigurationArgoCdAwsIdc), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfigurationArgoCdAwsIdc")]
        internal sealed class _Proxy : DeputyBase, aws.EksCapability.IEksCapabilityConfigurationArgoCdAwsIdc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#idc_instance_arn EksCapability#idc_instance_arn}.</summary>
            [JsiiProperty(name: "idcInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IdcInstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#idc_region EksCapability#idc_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idcRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdcRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
