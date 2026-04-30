using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamResourceDiscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOrganizationalUnitExclusion")]
    public class VpcIpamResourceDiscoveryOrganizationalUnitExclusion : aws.VpcIpamResourceDiscovery.IVpcIpamResourceDiscoveryOrganizationalUnitExclusion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/vpc_ipam_resource_discovery#organizations_entity_path VpcIpamResourceDiscovery#organizations_entity_path}.</summary>
        [JsiiProperty(name: "organizationsEntityPath", typeJson: "{\"primitive\":\"string\"}")]
        public string OrganizationsEntityPath
        {
            get;
            set;
        }
    }
}
