using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad")]
    public class GoldenGatePipelineProcessOptionsInitialDataLoad : oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#is_initial_load GoldenGatePipeline#is_initial_load}.</summary>
        [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
        public string IsInitialLoad
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#action_on_existing_table GoldenGatePipeline#action_on_existing_table}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionOnExistingTable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#adb_wallet_path GoldenGatePipeline#adb_wallet_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adbWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdbWalletPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#bucket GoldenGatePipeline#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#initial_load_type GoldenGatePipeline#initial_load_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialLoadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialLoadType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#namespace GoldenGatePipeline#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#source_wallet_path GoldenGatePipeline#source_wallet_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceWalletPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/golden_gate_pipeline#target_wallet_path GoldenGatePipeline#target_wallet_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetWalletPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetWalletPath
        {
            get;
            set;
        }
    }
}
