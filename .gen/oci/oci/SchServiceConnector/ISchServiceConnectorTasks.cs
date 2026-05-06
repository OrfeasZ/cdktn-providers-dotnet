using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorTasks), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorTasks")]
    public interface ISchServiceConnectorTasks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_kbs SchServiceConnector#batch_size_in_kbs}.</summary>
        [JsiiProperty(name: "batchSizeInKbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSizeInKbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_time_in_sec SchServiceConnector#batch_time_in_sec}.</summary>
        [JsiiProperty(name: "batchTimeInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchTimeInSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#condition SchServiceConnector#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#function_id SchServiceConnector#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorTasks), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorTasks")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorTasks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_kbs SchServiceConnector#batch_size_in_kbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSizeInKbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSizeInKbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_time_in_sec SchServiceConnector#batch_time_in_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchTimeInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchTimeInSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#condition SchServiceConnector#condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Condition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#function_id SchServiceConnector#function_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
