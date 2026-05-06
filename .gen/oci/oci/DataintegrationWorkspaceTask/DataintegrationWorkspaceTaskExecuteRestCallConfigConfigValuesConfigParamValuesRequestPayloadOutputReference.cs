using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRefValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue\"}}]")]
        public virtual void PutRefValue(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetParameterValue")]
        public virtual void ResetParameterValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefValue")]
        public virtual void ResetRefValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "refValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference RefValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParameterValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refValueInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue? RefValueInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue?>();
        }

        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParameterValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayload\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayload? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayload?>();
            set => SetInstanceProperty(value);
        }
    }
}
