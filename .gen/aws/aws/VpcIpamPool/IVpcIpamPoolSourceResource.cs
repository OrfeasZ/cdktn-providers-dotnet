using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamPool
{
    [JsiiInterface(nativeType: typeof(IVpcIpamPoolSourceResource), fullyQualifiedName: "aws.vpcIpamPool.VpcIpamPoolSourceResource")]
    public interface IVpcIpamPoolSourceResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_id VpcIpamPool#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_owner VpcIpamPool#resource_owner}.</summary>
        [JsiiProperty(name: "resourceOwner", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceOwner
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_region VpcIpamPool#resource_region}.</summary>
        [JsiiProperty(name: "resourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_type VpcIpamPool#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpamPoolSourceResource), fullyQualifiedName: "aws.vpcIpamPool.VpcIpamPoolSourceResource")]
        internal sealed class _Proxy : DeputyBase, aws.VpcIpamPool.IVpcIpamPoolSourceResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_id VpcIpamPool#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_owner VpcIpamPool#resource_owner}.</summary>
            [JsiiProperty(name: "resourceOwner", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceOwner
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_region VpcIpamPool#resource_region}.</summary>
            [JsiiProperty(name: "resourceRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_ipam_pool#resource_type VpcIpamPool#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
