using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArczonalshiftZonalAutoshiftConfiguration
{
    [JsiiInterface(nativeType: typeof(IArczonalshiftZonalAutoshiftConfigurationBlockingAlarms), fullyQualifiedName: "aws.arczonalshiftZonalAutoshiftConfiguration.ArczonalshiftZonalAutoshiftConfigurationBlockingAlarms")]
    public interface IArczonalshiftZonalAutoshiftConfigurationBlockingAlarms
    {
        /// <summary>ARN of the CloudWatch alarm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/arczonalshift_zonal_autoshift_configuration#alarm_identifier ArczonalshiftZonalAutoshiftConfiguration#alarm_identifier}
        /// </remarks>
        [JsiiProperty(name: "alarmIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmIdentifier
        {
            get;
        }

        /// <summary>Type of control condition. Valid value: `CLOUDWATCH`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/arczonalshift_zonal_autoshift_configuration#type ArczonalshiftZonalAutoshiftConfiguration#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArczonalshiftZonalAutoshiftConfigurationBlockingAlarms), fullyQualifiedName: "aws.arczonalshiftZonalAutoshiftConfiguration.ArczonalshiftZonalAutoshiftConfigurationBlockingAlarms")]
        internal sealed class _Proxy : DeputyBase, aws.ArczonalshiftZonalAutoshiftConfiguration.IArczonalshiftZonalAutoshiftConfigurationBlockingAlarms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ARN of the CloudWatch alarm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/arczonalshift_zonal_autoshift_configuration#alarm_identifier ArczonalshiftZonalAutoshiftConfiguration#alarm_identifier}
            /// </remarks>
            [JsiiProperty(name: "alarmIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of control condition. Valid value: `CLOUDWATCH`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/arczonalshift_zonal_autoshift_configuration#type ArczonalshiftZonalAutoshiftConfiguration#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
