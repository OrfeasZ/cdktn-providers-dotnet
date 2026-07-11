using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    [JsiiClass(nativeType: typeof(azurestack.WindowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference), fullyQualifiedName: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsVirtualMachineScaleSetBootDiagnosticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public virtual azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics? InternalValue
        {
            get => GetInstanceProperty<azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics?>();
            set => SetInstanceProperty(value);
        }
    }
}
