using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiClass(nativeType: typeof(oci.DevopsTrigger.DevopsTriggerActionsFilterExcludeOutputReference), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterExcludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsTriggerActionsFilterExcludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsTriggerActionsFilterExcludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsTriggerActionsFilterExcludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsTriggerActionsFilterExcludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFileFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter\"}}]")]
        public virtual void PutFileFilter(oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFileFilter")]
        public virtual void ResetFileFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilterOutputReference\"}")]
        public virtual oci.DevopsTrigger.DevopsTriggerActionsFilterExcludeFileFilterOutputReference FileFilter
        {
            get => GetInstanceProperty<oci.DevopsTrigger.DevopsTriggerActionsFilterExcludeFileFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileFilterInput", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter? FileFilterInput
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExclude\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude?>();
            set => SetInstanceProperty(value);
        }
    }
}
