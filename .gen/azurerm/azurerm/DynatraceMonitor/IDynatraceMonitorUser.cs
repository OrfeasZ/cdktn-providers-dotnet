using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    [JsiiInterface(nativeType: typeof(IDynatraceMonitorUser), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorUser")]
    public interface IDynatraceMonitorUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#email DynatraceMonitor#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#first_name DynatraceMonitor#first_name}.</summary>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        string FirstName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#last_name DynatraceMonitor#last_name}.</summary>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        string LastName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#country DynatraceMonitor#country}.</summary>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#phone_number DynatraceMonitor#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhoneNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynatraceMonitorUser), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorUser")]
        internal sealed class _Proxy : DeputyBase, azurerm.DynatraceMonitor.IDynatraceMonitorUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#email DynatraceMonitor#email}.</summary>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#first_name DynatraceMonitor#first_name}.</summary>
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
            public string FirstName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#last_name DynatraceMonitor#last_name}.</summary>
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
            public string LastName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#country DynatraceMonitor#country}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#phone_number DynatraceMonitor#phone_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhoneNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
