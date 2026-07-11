using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule" />)[]</param>
        [JsiiMethod(name: "putFridaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFridaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule" />)[]</param>
        [JsiiMethod(name: "putMondaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMondaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule" />)[]</param>
        [JsiiMethod(name: "putSaturdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSaturdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule" />)[]</param>
        [JsiiMethod(name: "putSundaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSundaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule" />)[]</param>
        [JsiiMethod(name: "putThursdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThursdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule" />)[]</param>
        [JsiiMethod(name: "putTuesdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTuesdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule" />)[]</param>
        [JsiiMethod(name: "putWednesdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWednesdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllWeekSchedule")]
        public virtual void ResetAllWeekSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFridaySchedule")]
        public virtual void ResetFridaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMondaySchedule")]
        public virtual void ResetMondaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaturdaySchedule")]
        public virtual void ResetSaturdaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSundaySchedule")]
        public virtual void ResetSundaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThursdaySchedule")]
        public virtual void ResetThursdaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeZoneName")]
        public virtual void ResetTimeZoneName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTuesdaySchedule")]
        public virtual void ResetTuesdaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWednesdaySchedule")]
        public virtual void ResetWednesdaySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridayScheduleList FridaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridayScheduleList>()!;
        }

        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondayScheduleList MondaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondayScheduleList>()!;
        }

        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdayScheduleList SaturdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdayScheduleList>()!;
        }

        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundayScheduleList SundaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundayScheduleList>()!;
        }

        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdayScheduleList ThursdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdayScheduleList>()!;
        }

        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdayScheduleList TuesdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdayScheduleList>()!;
        }

        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdayScheduleList WednesdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdayScheduleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allWeekScheduleInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AllWeekScheduleInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fridayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FridayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mondayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MondayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saturdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SaturdayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sundayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SundayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thursdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThursdayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeZoneNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeZoneNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tuesdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TuesdayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wednesdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WednesdayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllWeekSchedule
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZoneName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction?>();
            set => SetInstanceProperty(value);
        }
    }
}
