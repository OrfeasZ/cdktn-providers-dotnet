using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfigParamValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues\"}}]")]
        public virtual void PutConfigParamValues(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigParamValues")]
        public virtual void ResetConfigParamValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValuesOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValuesOutputReference ConfigParamValues
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValuesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configParamValuesInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues? ConfigParamValuesInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
