using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration : aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#storage_size_gib EcsCapacityProvider#storage_size_gib}.</summary>
        [JsiiProperty(name: "storageSizeGib", typeJson: "{\"primitive\":\"number\"}")]
        public double StorageSizeGib
        {
            get;
            set;
        }
    }
}
