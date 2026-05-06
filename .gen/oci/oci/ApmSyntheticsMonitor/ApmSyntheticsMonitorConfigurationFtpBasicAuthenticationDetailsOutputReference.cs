using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword\"}}]")]
        public virtual void PutPassword(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsername")]
        public virtual void ResetUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPasswordOutputReference\"}")]
        public virtual oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPasswordOutputReference Password
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPasswordOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword? PasswordInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
