using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowApplication
{
    [JsiiInterface(nativeType: typeof(IDataflowApplicationApplicationLogConfig), fullyQualifiedName: "oci.dataflowApplication.DataflowApplicationApplicationLogConfig")]
    public interface IDataflowApplicationApplicationLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#log_group_id DataflowApplication#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#log_id DataflowApplication#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        string LogId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataflowApplicationApplicationLogConfig), fullyQualifiedName: "oci.dataflowApplication.DataflowApplicationApplicationLogConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataflowApplication.IDataflowApplicationApplicationLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#log_group_id DataflowApplication#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_application#log_id DataflowApplication#log_id}.</summary>
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
