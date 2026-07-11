using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiInterface(nativeType: typeof(IAppServiceBackupSchedule), fullyQualifiedName: "azurerm.appService.AppServiceBackupSchedule")]
    public interface IAppServiceBackupSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#frequency_interval AppService#frequency_interval}.</summary>
        [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
        double FrequencyInterval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#frequency_unit AppService#frequency_unit}.</summary>
        [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
        string FrequencyUnit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#keep_at_least_one_backup AppService#keep_at_least_one_backup}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeepAtLeastOneBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#retention_period_in_days AppService#retention_period_in_days}.</summary>
        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriodInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#start_time AppService#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceBackupSchedule), fullyQualifiedName: "azurerm.appService.AppServiceBackupSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppService.IAppServiceBackupSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#frequency_interval AppService#frequency_interval}.</summary>
            [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
            public double FrequencyInterval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#frequency_unit AppService#frequency_unit}.</summary>
            [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string FrequencyUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#keep_at_least_one_backup AppService#keep_at_least_one_backup}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? KeepAtLeastOneBackup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#retention_period_in_days AppService#retention_period_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/app_service#start_time AppService#start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
