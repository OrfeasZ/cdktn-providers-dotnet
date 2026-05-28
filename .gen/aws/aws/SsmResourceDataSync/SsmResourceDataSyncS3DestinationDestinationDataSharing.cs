using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmResourceDataSync
{
    [JsiiByValue(fqn: "aws.ssmResourceDataSync.SsmResourceDataSyncS3DestinationDestinationDataSharing")]
    public class SsmResourceDataSyncS3DestinationDestinationDataSharing : aws.SsmResourceDataSync.ISsmResourceDataSyncS3DestinationDestinationDataSharing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/ssm_resource_data_sync#destination_data_sharing_type SsmResourceDataSync#destination_data_sharing_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationDataSharingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationDataSharingType
        {
            get;
            set;
        }
    }
}
