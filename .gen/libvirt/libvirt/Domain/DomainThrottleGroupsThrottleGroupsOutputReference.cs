using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainThrottleGroupsThrottleGroupsOutputReference), fullyQualifiedName: "libvirt.domain.DomainThrottleGroupsThrottleGroupsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainThrottleGroupsThrottleGroupsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainThrottleGroupsThrottleGroupsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainThrottleGroupsThrottleGroupsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainThrottleGroupsThrottleGroupsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGroupName")]
        public virtual void ResetGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadBytesSec")]
        public virtual void ResetReadBytesSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadBytesSecMax")]
        public virtual void ResetReadBytesSecMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadBytesSecMaxLength")]
        public virtual void ResetReadBytesSecMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadIopsSec")]
        public virtual void ResetReadIopsSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadIopsSecMax")]
        public virtual void ResetReadIopsSecMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadIopsSecMaxLength")]
        public virtual void ResetReadIopsSecMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizeIopsSec")]
        public virtual void ResetSizeIopsSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalBytesSec")]
        public virtual void ResetTotalBytesSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalBytesSecMax")]
        public virtual void ResetTotalBytesSecMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalBytesSecMaxLength")]
        public virtual void ResetTotalBytesSecMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalIopsSec")]
        public virtual void ResetTotalIopsSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalIopsSecMax")]
        public virtual void ResetTotalIopsSecMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalIopsSecMaxLength")]
        public virtual void ResetTotalIopsSecMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteBytesSec")]
        public virtual void ResetWriteBytesSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteBytesSecMax")]
        public virtual void ResetWriteBytesSecMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteBytesSecMaxLength")]
        public virtual void ResetWriteBytesSecMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteIopsSec")]
        public virtual void ResetWriteIopsSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteIopsSecMax")]
        public virtual void ResetWriteIopsSecMax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteIopsSecMaxLength")]
        public virtual void ResetWriteIopsSecMaxLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readBytesSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadBytesSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readBytesSecMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadBytesSecMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readBytesSecMaxLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadBytesSecMaxLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readIopsSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadIopsSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readIopsSecMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadIopsSecMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readIopsSecMaxLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadIopsSecMaxLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeIopsSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeIopsSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalBytesSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalBytesSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalBytesSecMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalBytesSecMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalBytesSecMaxLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalBytesSecMaxLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalIopsSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalIopsSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalIopsSecMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalIopsSecMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalIopsSecMaxLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalIopsSecMaxLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeBytesSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteBytesSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeBytesSecMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteBytesSecMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeBytesSecMaxLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteBytesSecMaxLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeIopsSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteIopsSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeIopsSecMaxInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteIopsSecMaxInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeIopsSecMaxLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteIopsSecMaxLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readBytesSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadBytesSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readBytesSecMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadBytesSecMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadBytesSecMaxLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readIopsSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadIopsSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readIopsSecMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadIopsSecMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadIopsSecMaxLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeIopsSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeIopsSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalBytesSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalBytesSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalBytesSecMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalBytesSecMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalBytesSecMaxLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalIopsSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalIopsSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalIopsSecMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalIopsSecMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalIopsSecMaxLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeBytesSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteBytesSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeBytesSecMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteBytesSecMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeBytesSecMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteBytesSecMaxLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeIopsSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteIopsSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeIopsSecMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteIopsSecMax
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeIopsSecMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteIopsSecMaxLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainThrottleGroupsThrottleGroups\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainThrottleGroupsThrottleGroups cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainThrottleGroupsThrottleGroups).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
