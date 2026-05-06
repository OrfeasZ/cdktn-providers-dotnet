using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceOsPatchAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsInstanceOsPatchAction.BdsBdsInstanceOsPatchActionPatchingConfigs")]
    public class BdsBdsInstanceOsPatchActionPatchingConfigs : oci.BdsBdsInstanceOsPatchAction.IBdsBdsInstanceOsPatchActionPatchingConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#patching_config_strategy BdsBdsInstanceOsPatchAction#patching_config_strategy}.</summary>
        [JsiiProperty(name: "patchingConfigStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string PatchingConfigStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#batch_size BdsBdsInstanceOsPatchAction#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#tolerance_threshold_per_batch BdsBdsInstanceOsPatchAction#tolerance_threshold_per_batch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toleranceThresholdPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ToleranceThresholdPerBatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#tolerance_threshold_per_domain BdsBdsInstanceOsPatchAction#tolerance_threshold_per_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toleranceThresholdPerDomain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ToleranceThresholdPerDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#wait_time_between_batch_in_seconds BdsBdsInstanceOsPatchAction#wait_time_between_batch_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitTimeBetweenBatchInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitTimeBetweenBatchInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#wait_time_between_domain_in_seconds BdsBdsInstanceOsPatchAction#wait_time_between_domain_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitTimeBetweenDomainInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitTimeBetweenDomainInSeconds
        {
            get;
            set;
        }
    }
}
