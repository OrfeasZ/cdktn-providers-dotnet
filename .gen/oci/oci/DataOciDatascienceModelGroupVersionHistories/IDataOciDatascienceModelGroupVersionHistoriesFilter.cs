using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModelGroupVersionHistories
{
    [JsiiInterface(nativeType: typeof(IDataOciDatascienceModelGroupVersionHistoriesFilter), fullyQualifiedName: "oci.dataOciDatascienceModelGroupVersionHistories.DataOciDatascienceModelGroupVersionHistoriesFilter")]
    public interface IDataOciDatascienceModelGroupVersionHistoriesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model_group_version_histories#name DataOciDatascienceModelGroupVersionHistories#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model_group_version_histories#values DataOciDatascienceModelGroupVersionHistories#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model_group_version_histories#regex DataOciDatascienceModelGroupVersionHistories#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatascienceModelGroupVersionHistoriesFilter), fullyQualifiedName: "oci.dataOciDatascienceModelGroupVersionHistories.DataOciDatascienceModelGroupVersionHistoriesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatascienceModelGroupVersionHistories.IDataOciDatascienceModelGroupVersionHistoriesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model_group_version_histories#name DataOciDatascienceModelGroupVersionHistories#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model_group_version_histories#values DataOciDatascienceModelGroupVersionHistories#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_model_group_version_histories#regex DataOciDatascienceModelGroupVersionHistories#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
