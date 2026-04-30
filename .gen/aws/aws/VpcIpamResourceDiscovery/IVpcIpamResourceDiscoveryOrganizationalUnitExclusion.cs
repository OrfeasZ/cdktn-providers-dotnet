using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamResourceDiscovery
{
    [JsiiInterface(nativeType: typeof(IVpcIpamResourceDiscoveryOrganizationalUnitExclusion), fullyQualifiedName: "aws.vpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOrganizationalUnitExclusion")]
    public interface IVpcIpamResourceDiscoveryOrganizationalUnitExclusion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpc_ipam_resource_discovery#organizations_entity_path VpcIpamResourceDiscovery#organizations_entity_path}.</summary>
        [JsiiProperty(name: "organizationsEntityPath", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationsEntityPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpamResourceDiscoveryOrganizationalUnitExclusion), fullyQualifiedName: "aws.vpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOrganizationalUnitExclusion")]
        internal sealed class _Proxy : DeputyBase, aws.VpcIpamResourceDiscovery.IVpcIpamResourceDiscoveryOrganizationalUnitExclusion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpc_ipam_resource_discovery#organizations_entity_path VpcIpamResourceDiscovery#organizations_entity_path}.</summary>
            [JsiiProperty(name: "organizationsEntityPath", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationsEntityPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
