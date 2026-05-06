using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfigValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues\"}}]")]
        public virtual void PutConfigValues(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigValues")]
        public virtual void ResetConfigValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKey")]
        public virtual void ResetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelType")]
        public virtual void ResetModelType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference ConfigValues
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configValuesInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues? ConfigValuesInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue?>();
            set => SetInstanceProperty(value);
        }
    }
}
