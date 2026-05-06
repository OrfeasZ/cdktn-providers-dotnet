using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiInterface(nativeType: typeof(IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails")]
    public interface IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image DatascienceSchedule#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_environment_type DatascienceSchedule#job_environment_type}.</summary>
        [JsiiProperty(name: "jobEnvironmentType", typeJson: "{\"primitive\":\"string\"}")]
        string JobEnvironmentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#cmd DatascienceSchedule#cmd}.</summary>
        [JsiiProperty(name: "cmd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Cmd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#entrypoint DatascienceSchedule#entrypoint}.</summary>
        [JsiiProperty(name: "entrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Entrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image_digest DatascienceSchedule#image_digest}.</summary>
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageDigest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image_signature_id DatascienceSchedule#image_signature_id}.</summary>
        [JsiiProperty(name: "imageSignatureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageSignatureId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image DatascienceSchedule#image}.</summary>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_environment_type DatascienceSchedule#job_environment_type}.</summary>
            [JsiiProperty(name: "jobEnvironmentType", typeJson: "{\"primitive\":\"string\"}")]
            public string JobEnvironmentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#cmd DatascienceSchedule#cmd}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cmd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Cmd
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#entrypoint DatascienceSchedule#entrypoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Entrypoint
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image_digest DatascienceSchedule#image_digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageDigest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image_signature_id DatascienceSchedule#image_signature_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageSignatureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageSignatureId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
