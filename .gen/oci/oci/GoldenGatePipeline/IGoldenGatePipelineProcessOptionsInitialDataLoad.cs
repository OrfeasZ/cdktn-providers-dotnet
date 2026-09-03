using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiInterface(nativeType: typeof(IGoldenGatePipelineProcessOptionsInitialDataLoad), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad")]
    public interface IGoldenGatePipelineProcessOptionsInitialDataLoad
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#is_initial_load GoldenGatePipeline#is_initial_load}.</summary>
        [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
        string IsInitialLoad
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#action_on_existing_table GoldenGatePipeline#action_on_existing_table}.</summary>
        [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnExistingTable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#adb_wallet_path GoldenGatePipeline#adb_wallet_path}.</summary>
        [JsiiProperty(name: "adbWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdbWalletPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#bucket GoldenGatePipeline#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#initial_load_type GoldenGatePipeline#initial_load_type}.</summary>
        [JsiiProperty(name: "initialLoadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitialLoadType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#namespace GoldenGatePipeline#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#source_wallet_path GoldenGatePipeline#source_wallet_path}.</summary>
        [JsiiProperty(name: "sourceWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceWalletPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#target_wallet_path GoldenGatePipeline#target_wallet_path}.</summary>
        [JsiiProperty(name: "targetWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetWalletPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGatePipelineProcessOptionsInitialDataLoad), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#is_initial_load GoldenGatePipeline#is_initial_load}.</summary>
            [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
            public string IsInitialLoad
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#action_on_existing_table GoldenGatePipeline#action_on_existing_table}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnExistingTable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#adb_wallet_path GoldenGatePipeline#adb_wallet_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adbWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdbWalletPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#bucket GoldenGatePipeline#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#initial_load_type GoldenGatePipeline#initial_load_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialLoadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitialLoadType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#namespace GoldenGatePipeline#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#source_wallet_path GoldenGatePipeline#source_wallet_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceWalletPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/golden_gate_pipeline#target_wallet_path GoldenGatePipeline#target_wallet_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetWalletPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
