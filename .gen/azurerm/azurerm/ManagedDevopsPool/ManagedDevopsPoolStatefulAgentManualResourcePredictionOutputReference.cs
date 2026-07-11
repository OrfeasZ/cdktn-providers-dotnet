using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule" />)[]</param>
        [JsiiMethod(name: "putFridaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFridaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule" />)[]</param>
        [JsiiMethod(name: "putMondaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMondaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule" />)[]</param>
        [JsiiMethod(name: "putSaturdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSaturdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule" />)[]</param>
        [JsiiMethod(name: "putSundaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSundaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule" />)[]</param>
        [JsiiMethod(name: "putThursdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThursdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule" />)[]</param>
        [JsiiMethod(name: "putTuesdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTuesdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule" />)[]</param>
        [JsiiMethod(name: "putWednesdaySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWednesdaySchedule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridayScheduleList FridaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridayScheduleList>()!;
        }

        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondayScheduleList MondaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondayScheduleList>()!;
        }

        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdayScheduleList SaturdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdayScheduleList>()!;
        }

        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundayScheduleList SundaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundayScheduleList>()!;
        }

        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdayScheduleList ThursdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdayScheduleList>()!;
        }

        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdayScheduleList TuesdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdayScheduleList>()!;
        }

        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdayScheduleList\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdayScheduleList WednesdaySchedule
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdayScheduleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allWeekScheduleInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AllWeekScheduleInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fridayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FridayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mondayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionMondaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MondayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saturdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SaturdayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sundayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionSundaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SundayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thursdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionThursdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tuesdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TuesdayScheduleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wednesdayScheduleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction?>();
            set => SetInstanceProperty(value);
        }
    }
}
