using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceOsPatchAction
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceOsPatchActionPatchingConfigs), fullyQualifiedName: "oci.bdsBdsInstanceOsPatchAction.BdsBdsInstanceOsPatchActionPatchingConfigs")]
    public interface IBdsBdsInstanceOsPatchActionPatchingConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#patching_config_strategy BdsBdsInstanceOsPatchAction#patching_config_strategy}.</summary>
        [JsiiProperty(name: "patchingConfigStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string PatchingConfigStrategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#batch_size BdsBdsInstanceOsPatchAction#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#tolerance_threshold_per_batch BdsBdsInstanceOsPatchAction#tolerance_threshold_per_batch}.</summary>
        [JsiiProperty(name: "toleranceThresholdPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToleranceThresholdPerBatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#tolerance_threshold_per_domain BdsBdsInstanceOsPatchAction#tolerance_threshold_per_domain}.</summary>
        [JsiiProperty(name: "toleranceThresholdPerDomain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToleranceThresholdPerDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#wait_time_between_batch_in_seconds BdsBdsInstanceOsPatchAction#wait_time_between_batch_in_seconds}.</summary>
        [JsiiProperty(name: "waitTimeBetweenBatchInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeBetweenBatchInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#wait_time_between_domain_in_seconds BdsBdsInstanceOsPatchAction#wait_time_between_domain_in_seconds}.</summary>
        [JsiiProperty(name: "waitTimeBetweenDomainInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeBetweenDomainInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceOsPatchActionPatchingConfigs), fullyQualifiedName: "oci.bdsBdsInstanceOsPatchAction.BdsBdsInstanceOsPatchActionPatchingConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceOsPatchAction.IBdsBdsInstanceOsPatchActionPatchingConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#patching_config_strategy BdsBdsInstanceOsPatchAction#patching_config_strategy}.</summary>
            [JsiiProperty(name: "patchingConfigStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string PatchingConfigStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#batch_size BdsBdsInstanceOsPatchAction#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#tolerance_threshold_per_batch BdsBdsInstanceOsPatchAction#tolerance_threshold_per_batch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toleranceThresholdPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToleranceThresholdPerBatch
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#tolerance_threshold_per_domain BdsBdsInstanceOsPatchAction#tolerance_threshold_per_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toleranceThresholdPerDomain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToleranceThresholdPerDomain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#wait_time_between_batch_in_seconds BdsBdsInstanceOsPatchAction#wait_time_between_batch_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimeBetweenBatchInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeBetweenBatchInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_os_patch_action#wait_time_between_domain_in_seconds BdsBdsInstanceOsPatchAction#wait_time_between_domain_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimeBetweenDomainInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeBetweenDomainInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
