using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemRootSquashOutputReference), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquashOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedLustreFileSystemRootSquashOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedLustreFileSystemRootSquashOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedLustreFileSystemRootSquashOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedLustreFileSystemRootSquashOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSquashGid")]
        public virtual void ResetSquashGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSquashUid")]
        public virtual void ResetSquashUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noSquashNidsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NoSquashNidsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "squashGidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SquashGidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "squashUidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SquashUidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "noSquashNids", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NoSquashNids
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "squashGid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SquashGid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "squashUid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SquashUid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquash\"}", isOptional: true)]
        public virtual azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash?>();
            set => SetInstanceProperty(value);
        }
    }
}
