using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelsApplyDiscoveryJobResults
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveDataModelsApplyDiscoveryJobResultsTimeouts), fullyQualifiedName: "oci.dataSafeSensitiveDataModelsApplyDiscoveryJobResults.DataSafeSensitiveDataModelsApplyDiscoveryJobResultsTimeouts")]
    public interface IDataSafeSensitiveDataModelsApplyDiscoveryJobResultsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_apply_discovery_job_results#create DataSafeSensitiveDataModelsApplyDiscoveryJobResults#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_apply_discovery_job_results#delete DataSafeSensitiveDataModelsApplyDiscoveryJobResults#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_apply_discovery_job_results#update DataSafeSensitiveDataModelsApplyDiscoveryJobResults#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveDataModelsApplyDiscoveryJobResultsTimeouts), fullyQualifiedName: "oci.dataSafeSensitiveDataModelsApplyDiscoveryJobResults.DataSafeSensitiveDataModelsApplyDiscoveryJobResultsTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveDataModelsApplyDiscoveryJobResults.IDataSafeSensitiveDataModelsApplyDiscoveryJobResultsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_apply_discovery_job_results#create DataSafeSensitiveDataModelsApplyDiscoveryJobResults#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_apply_discovery_job_results#delete DataSafeSensitiveDataModelsApplyDiscoveryJobResults#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_apply_discovery_job_results#update DataSafeSensitiveDataModelsApplyDiscoveryJobResults#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
