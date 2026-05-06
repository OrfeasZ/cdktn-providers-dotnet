using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowInvokeRun
{
    [JsiiInterface(nativeType: typeof(IDataflowInvokeRunApplicationLogConfig), fullyQualifiedName: "oci.dataflowInvokeRun.DataflowInvokeRunApplicationLogConfig")]
    public interface IDataflowInvokeRunApplicationLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#log_group_id DataflowInvokeRun#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#log_id DataflowInvokeRun#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        string LogId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowInvokeRunApplicationLogConfig), fullyQualifiedName: "oci.dataflowInvokeRun.DataflowInvokeRunApplicationLogConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowInvokeRun.IDataflowInvokeRunApplicationLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#log_group_id DataflowInvokeRun#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#log_id DataflowInvokeRun#log_id}.</summary>
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
