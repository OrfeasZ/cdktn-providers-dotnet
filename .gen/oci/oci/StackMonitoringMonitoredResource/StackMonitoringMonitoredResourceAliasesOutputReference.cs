using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResource
{
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesOutputReference), fullyQualifiedName: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackMonitoringMonitoredResourceAliasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackMonitoringMonitoredResourceAliasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackMonitoringMonitoredResourceAliasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourceAliasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredential\"}}]")]
        public virtual void PutCredential(oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential)}, new object[]{@value});
        }

        [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredentialOutputReference\"}")]
        public virtual oci.StackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredentialOutputReference Credential
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredentialOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialInput", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredential\"}", isOptional: true)]
        public virtual oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential? CredentialInput
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliases\"}", isOptional: true)]
        public virtual oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliases? InternalValue
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliases?>();
            set => SetInstanceProperty(value);
        }
    }
}
