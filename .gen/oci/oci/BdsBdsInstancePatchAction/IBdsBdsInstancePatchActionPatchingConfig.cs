using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstancePatchAction
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstancePatchActionPatchingConfig), fullyQualifiedName: "oci.bdsBdsInstancePatchAction.BdsBdsInstancePatchActionPatchingConfig")]
    public interface IBdsBdsInstancePatchActionPatchingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#patching_config_strategy BdsBdsInstancePatchAction#patching_config_strategy}.</summary>
        [JsiiProperty(name: "patchingConfigStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string PatchingConfigStrategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#batch_size BdsBdsInstancePatchAction#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#tolerance_threshold_per_batch BdsBdsInstancePatchAction#tolerance_threshold_per_batch}.</summary>
        [JsiiProperty(name: "toleranceThresholdPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToleranceThresholdPerBatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#tolerance_threshold_per_domain BdsBdsInstancePatchAction#tolerance_threshold_per_domain}.</summary>
        [JsiiProperty(name: "toleranceThresholdPerDomain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToleranceThresholdPerDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#wait_time_between_batch_in_seconds BdsBdsInstancePatchAction#wait_time_between_batch_in_seconds}.</summary>
        [JsiiProperty(name: "waitTimeBetweenBatchInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeBetweenBatchInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#wait_time_between_domain_in_seconds BdsBdsInstancePatchAction#wait_time_between_domain_in_seconds}.</summary>
        [JsiiProperty(name: "waitTimeBetweenDomainInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeBetweenDomainInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstancePatchActionPatchingConfig), fullyQualifiedName: "oci.bdsBdsInstancePatchAction.BdsBdsInstancePatchActionPatchingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstancePatchAction.IBdsBdsInstancePatchActionPatchingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#patching_config_strategy BdsBdsInstancePatchAction#patching_config_strategy}.</summary>
            [JsiiProperty(name: "patchingConfigStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string PatchingConfigStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#batch_size BdsBdsInstancePatchAction#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#tolerance_threshold_per_batch BdsBdsInstancePatchAction#tolerance_threshold_per_batch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toleranceThresholdPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToleranceThresholdPerBatch
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#tolerance_threshold_per_domain BdsBdsInstancePatchAction#tolerance_threshold_per_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toleranceThresholdPerDomain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToleranceThresholdPerDomain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#wait_time_between_batch_in_seconds BdsBdsInstancePatchAction#wait_time_between_batch_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimeBetweenBatchInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeBetweenBatchInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_patch_action#wait_time_between_domain_in_seconds BdsBdsInstancePatchAction#wait_time_between_domain_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "waitTimeBetweenDomainInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeBetweenDomainInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
