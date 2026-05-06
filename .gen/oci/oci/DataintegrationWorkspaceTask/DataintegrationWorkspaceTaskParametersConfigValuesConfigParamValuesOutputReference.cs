using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfigParamValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue\"}}]")]
        public virtual void PutConfigParamValue(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigParamValue")]
        public virtual void ResetConfigParamValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKey")]
        public virtual void ResetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "configParamValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference ConfigParamValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configParamValueInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue? ConfigParamValueInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
