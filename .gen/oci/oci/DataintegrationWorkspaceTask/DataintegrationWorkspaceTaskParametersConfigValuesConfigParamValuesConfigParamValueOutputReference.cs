using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRefValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValue\"}}]")]
        public virtual void PutRefValue(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRootObjectValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValue\"}}]")]
        public virtual void PutRootObjectValue(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIntValue")]
        public virtual void ResetIntValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectValue")]
        public virtual void ResetObjectValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetRootObjectValue")]
        public virtual void ResetRootObjectValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringValue")]
        public virtual void ResetStringValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "refValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValueOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValueOutputReference RefValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValueOutputReference>()!;
        }

        [JsiiProperty(name: "rootObjectValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValueOutputReference\"}")]
        public virtual oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValueOutputReference RootObjectValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "intValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParameterValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refValueInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValue\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValue? RefValueInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRefValue?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootObjectValueInput", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValue\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValue? RootObjectValueInput
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValueRootObjectValue?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StringValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "intValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParameterValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StringValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersConfigValuesConfigParamValuesConfigParamValue?>();
            set => SetInstanceProperty(value);
        }
    }
}
