using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiClass(nativeType: typeof(oci.DevopsTrigger.DevopsTriggerActionsFilterIncludeOutputReference), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterIncludeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsTriggerActionsFilterIncludeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsTriggerActionsFilterIncludeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsTriggerActionsFilterIncludeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsTriggerActionsFilterIncludeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFileFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeFileFilter\"}}]")]
        public virtual void PutFileFilter(oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBaseRef")]
        public virtual void ResetBaseRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileFilter")]
        public virtual void ResetFileFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeadRef")]
        public virtual void ResetHeadRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryName")]
        public virtual void ResetRepositoryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeFileFilterOutputReference\"}")]
        public virtual oci.DevopsTrigger.DevopsTriggerActionsFilterIncludeFileFilterOutputReference FileFilter
        {
            get => GetInstanceProperty<oci.DevopsTrigger.DevopsTriggerActionsFilterIncludeFileFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseRefInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseRefInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileFilterInput", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeFileFilter\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter? FileFilterInput
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headRefInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HeadRefInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseRef
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeadRef
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterInclude\"}", isOptional: true)]
        public virtual oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude?>();
            set => SetInstanceProperty(value);
        }
    }
}
