using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplication
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceApplication.DataintegrationWorkspaceApplicationSourceApplicationInfoOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceApplication.DataintegrationWorkspaceApplicationSourceApplicationInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceApplicationSourceApplicationInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceApplicationSourceApplicationInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceApplicationSourceApplicationInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceApplicationSourceApplicationInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetApplicationKey")]
        public virtual void ResetApplicationKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyType")]
        public virtual void ResetCopyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceId")]
        public virtual void ResetWorkspaceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastPatchKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastPatchKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CopyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "copyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CopyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplication.DataintegrationWorkspaceApplicationSourceApplicationInfo\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceApplication.IDataintegrationWorkspaceApplicationSourceApplicationInfo? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceApplication.IDataintegrationWorkspaceApplicationSourceApplicationInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
