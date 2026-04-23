using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesSynchronizationConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3FilesSynchronizationConfigurationImportDataRule), fullyQualifiedName: "aws.s3FilesSynchronizationConfiguration.S3FilesSynchronizationConfigurationImportDataRule")]
    public interface IS3FilesSynchronizationConfigurationImportDataRule
    {
        /// <summary>S3 prefix for import.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#prefix S3FilesSynchronizationConfiguration#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Maximum file size to import.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#size_less_than S3FilesSynchronizationConfiguration#size_less_than}
        /// </remarks>
        [JsiiProperty(name: "sizeLessThan", typeJson: "{\"primitive\":\"number\"}")]
        double SizeLessThan
        {
            get;
        }

        /// <summary>Import trigger type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#trigger S3FilesSynchronizationConfiguration#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"primitive\":\"string\"}")]
        string Trigger
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3FilesSynchronizationConfigurationImportDataRule), fullyQualifiedName: "aws.s3FilesSynchronizationConfiguration.S3FilesSynchronizationConfigurationImportDataRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3FilesSynchronizationConfiguration.IS3FilesSynchronizationConfigurationImportDataRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>S3 prefix for import.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#prefix S3FilesSynchronizationConfiguration#prefix}
            /// </remarks>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Maximum file size to import.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#size_less_than S3FilesSynchronizationConfiguration#size_less_than}
            /// </remarks>
            [JsiiProperty(name: "sizeLessThan", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeLessThan
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Import trigger type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_synchronization_configuration#trigger S3FilesSynchronizationConfiguration#trigger}
            /// </remarks>
            [JsiiProperty(name: "trigger", typeJson: "{\"primitive\":\"string\"}")]
            public string Trigger
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
