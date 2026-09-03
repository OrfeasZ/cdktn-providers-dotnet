using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    [JsiiInterface(nativeType: typeof(IMonitorActionGroupArmRoleReceiver), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiver")]
    public interface IMonitorActionGroupArmRoleReceiver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_action_group#role_id MonitorActionGroup#role_id}.</summary>
        [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_action_group#use_common_alert_schema MonitorActionGroup#use_common_alert_schema}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useCommonAlertSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCommonAlertSchema
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorActionGroupArmRoleReceiver), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiver")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorActionGroup.IMonitorActionGroupArmRoleReceiver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_action_group#role_id MonitorActionGroup#role_id}.</summary>
            [JsiiProperty(name: "roleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/monitor_action_group#use_common_alert_schema MonitorActionGroup#use_common_alert_schema}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useCommonAlertSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UseCommonAlertSchema
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
