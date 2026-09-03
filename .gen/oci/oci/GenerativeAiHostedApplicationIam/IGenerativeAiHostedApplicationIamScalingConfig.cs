using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationIamScalingConfig), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamScalingConfig")]
    public interface IGenerativeAiHostedApplicationIamScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#scaling_type GenerativeAiHostedApplicationIam#scaling_type}.</summary>
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}")]
        string ScalingType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#max_replica GenerativeAiHostedApplicationIam#max_replica}.</summary>
        [JsiiProperty(name: "maxReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxReplica
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#min_replica GenerativeAiHostedApplicationIam#min_replica}.</summary>
        [JsiiProperty(name: "minReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinReplica
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_concurrency_threshold GenerativeAiHostedApplicationIam#target_concurrency_threshold}.</summary>
        [JsiiProperty(name: "targetConcurrencyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetConcurrencyThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_cpu_threshold GenerativeAiHostedApplicationIam#target_cpu_threshold}.</summary>
        [JsiiProperty(name: "targetCpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetCpuThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_memory_threshold GenerativeAiHostedApplicationIam#target_memory_threshold}.</summary>
        [JsiiProperty(name: "targetMemoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetMemoryThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_rps_threshold GenerativeAiHostedApplicationIam#target_rps_threshold}.</summary>
        [JsiiProperty(name: "targetRpsThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetRpsThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationIamScalingConfig), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamScalingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#scaling_type GenerativeAiHostedApplicationIam#scaling_type}.</summary>
            [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}")]
            public string ScalingType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#max_replica GenerativeAiHostedApplicationIam#max_replica}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxReplica
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#min_replica GenerativeAiHostedApplicationIam#min_replica}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minReplica", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinReplica
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_concurrency_threshold GenerativeAiHostedApplicationIam#target_concurrency_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetConcurrencyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetConcurrencyThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_cpu_threshold GenerativeAiHostedApplicationIam#target_cpu_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetCpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetCpuThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_memory_threshold GenerativeAiHostedApplicationIam#target_memory_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetMemoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetMemoryThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_hosted_application_iam#target_rps_threshold GenerativeAiHostedApplicationIam#target_rps_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetRpsThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetRpsThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
