// This source file is generated by nclang PInvokeGenerator.
using System;
using System.Runtime.InteropServices;
using delegate0 = SoundIOSharp.Delegates.delegate0;
using delegate1 = SoundIOSharp.Delegates.delegate1;
using delegate2 = SoundIOSharp.Delegates.delegate2;
using delegate3 = SoundIOSharp.Delegates.delegate3;
using delegate4 = SoundIOSharp.Delegates.delegate4;
using delegate5 = SoundIOSharp.Delegates.delegate5;
using delegate6 = SoundIOSharp.Delegates.delegate6;
using delegate7 = SoundIOSharp.Delegates.delegate7;
using delegate8 = SoundIOSharp.Delegates.delegate8;
using delegate9 = SoundIOSharp.Delegates.delegate9;

namespace SoundIOSharp
{
    enum SoundIoError // soundio.h (72, 6)
    {
        SoundIoErrorNone = 0,
        SoundIoErrorNoMem = 1,
        SoundIoErrorInitAudioBackend = 2,
        SoundIoErrorSystemResources = 3,
        SoundIoErrorOpeningDevice = 4,
        SoundIoErrorNoSuchDevice = 5,
        SoundIoErrorInvalid = 6,
        SoundIoErrorBackendUnavailable = 7,
        SoundIoErrorStreaming = 8,
        SoundIoErrorIncompatibleDevice = 9,
        SoundIoErrorNoSuchClient = 10,
        SoundIoErrorIncompatibleBackend = 11,
        SoundIoErrorBackendDisconnected = 12,
        SoundIoErrorInterrupted = 13,
        SoundIoErrorUnderflow = 14,
        SoundIoErrorEncodingString = 15,
    }

    enum SoundIoChannelId // soundio.h (106, 6)
    {
        SoundIoChannelIdInvalid = 0,
        SoundIoChannelIdFrontLeft = 1,
        SoundIoChannelIdFrontRight = 2,
        SoundIoChannelIdFrontCenter = 3,
        SoundIoChannelIdLfe = 4,
        SoundIoChannelIdBackLeft = 5,
        SoundIoChannelIdBackRight = 6,
        SoundIoChannelIdFrontLeftCenter = 7,
        SoundIoChannelIdFrontRightCenter = 8,
        SoundIoChannelIdBackCenter = 9,
        SoundIoChannelIdSideLeft = 10,
        SoundIoChannelIdSideRight = 11,
        SoundIoChannelIdTopCenter = 12,
        SoundIoChannelIdTopFrontLeft = 13,
        SoundIoChannelIdTopFrontCenter = 14,
        SoundIoChannelIdTopFrontRight = 15,
        SoundIoChannelIdTopBackLeft = 16,
        SoundIoChannelIdTopBackCenter = 17,
        SoundIoChannelIdTopBackRight = 18,
        SoundIoChannelIdBackLeftCenter = 19,
        SoundIoChannelIdBackRightCenter = 20,
        SoundIoChannelIdFrontLeftWide = 21,
        SoundIoChannelIdFrontRightWide = 22,
        SoundIoChannelIdFrontLeftHigh = 23,
        SoundIoChannelIdFrontCenterHigh = 24,
        SoundIoChannelIdFrontRightHigh = 25,
        SoundIoChannelIdTopFrontLeftCenter = 26,
        SoundIoChannelIdTopFrontRightCenter = 27,
        SoundIoChannelIdTopSideLeft = 28,
        SoundIoChannelIdTopSideRight = 29,
        SoundIoChannelIdLeftLfe = 30,
        SoundIoChannelIdRightLfe = 31,
        SoundIoChannelIdLfe2 = 32,
        SoundIoChannelIdBottomCenter = 33,
        SoundIoChannelIdBottomLeftCenter = 34,
        SoundIoChannelIdBottomRightCenter = 35,
        SoundIoChannelIdMsMid = 36,
        SoundIoChannelIdMsSide = 37,
        SoundIoChannelIdAmbisonicW = 38,
        SoundIoChannelIdAmbisonicX = 39,
        SoundIoChannelIdAmbisonicY = 40,
        SoundIoChannelIdAmbisonicZ = 41,
        SoundIoChannelIdXyX = 42,
        SoundIoChannelIdXyY = 43,
        SoundIoChannelIdHeadphonesLeft = 44,
        SoundIoChannelIdHeadphonesRight = 45,
        SoundIoChannelIdClickTrack = 46,
        SoundIoChannelIdForeignLanguage = 47,
        SoundIoChannelIdHearingImpaired = 48,
        SoundIoChannelIdNarration = 49,
        SoundIoChannelIdHaptic = 50,
        SoundIoChannelIdDialogCentricMix = 51,
        SoundIoChannelIdAux = 52,
        SoundIoChannelIdAux0 = 53,
        SoundIoChannelIdAux1 = 54,
        SoundIoChannelIdAux2 = 55,
        SoundIoChannelIdAux3 = 56,
        SoundIoChannelIdAux4 = 57,
        SoundIoChannelIdAux5 = 58,
        SoundIoChannelIdAux6 = 59,
        SoundIoChannelIdAux7 = 60,
        SoundIoChannelIdAux8 = 61,
        SoundIoChannelIdAux9 = 62,
        SoundIoChannelIdAux10 = 63,
        SoundIoChannelIdAux11 = 64,
        SoundIoChannelIdAux12 = 65,
        SoundIoChannelIdAux13 = 66,
        SoundIoChannelIdAux14 = 67,
        SoundIoChannelIdAux15 = 68,
    }

    enum SoundIoChannelLayoutId // soundio.h (189, 6)
    {
        SoundIoChannelLayoutIdMono = 0,
        SoundIoChannelLayoutIdStereo = 1,
        SoundIoChannelLayoutId2Point1 = 2,
        SoundIoChannelLayoutId3Point0 = 3,
        SoundIoChannelLayoutId3Point0Back = 4,
        SoundIoChannelLayoutId3Point1 = 5,
        SoundIoChannelLayoutId4Point0 = 6,
        SoundIoChannelLayoutIdQuad = 7,
        SoundIoChannelLayoutIdQuadSide = 8,
        SoundIoChannelLayoutId4Point1 = 9,
        SoundIoChannelLayoutId5Point0Back = 10,
        SoundIoChannelLayoutId5Point0Side = 11,
        SoundIoChannelLayoutId5Point1 = 12,
        SoundIoChannelLayoutId5Point1Back = 13,
        SoundIoChannelLayoutId6Point0Side = 14,
        SoundIoChannelLayoutId6Point0Front = 15,
        SoundIoChannelLayoutIdHexagonal = 16,
        SoundIoChannelLayoutId6Point1 = 17,
        SoundIoChannelLayoutId6Point1Back = 18,
        SoundIoChannelLayoutId6Point1Front = 19,
        SoundIoChannelLayoutId7Point0 = 20,
        SoundIoChannelLayoutId7Point0Front = 21,
        SoundIoChannelLayoutId7Point1 = 22,
        SoundIoChannelLayoutId7Point1Wide = 23,
        SoundIoChannelLayoutId7Point1WideBack = 24,
        SoundIoChannelLayoutIdOctagonal = 25,
    }

    enum SoundIoBackend // soundio.h (218, 6)
    {
        SoundIoBackendNone = 0,
        SoundIoBackendJack = 1,
        SoundIoBackendPulseAudio = 2,
        SoundIoBackendAlsa = 3,
        SoundIoBackendCoreAudio = 4,
        SoundIoBackendWasapi = 5,
        SoundIoBackendDummy = 6,
    }

    enum SoundIoDeviceAim // soundio.h (228, 6)
    {
        SoundIoDeviceAimInput = 0,
        SoundIoDeviceAimOutput = 1,
    }

    enum SoundIoFormat // soundio.h (235, 6)
    {
        SoundIoFormatInvalid = 0,
        SoundIoFormatS8 = 1,
        SoundIoFormatU8 = 2,
        SoundIoFormatS16LE = 3,
        SoundIoFormatS16BE = 4,
        SoundIoFormatU16LE = 5,
        SoundIoFormatU16BE = 6,
        SoundIoFormatS24LE = 7,
        SoundIoFormatS24BE = 8,
        SoundIoFormatU24LE = 9,
        SoundIoFormatU24BE = 10,
        SoundIoFormatS32LE = 11,
        SoundIoFormatS32BE = 12,
        SoundIoFormatU32LE = 13,
        SoundIoFormatU32BE = 14,
        SoundIoFormatFloat32LE = 15,
        SoundIoFormatFloat32BE = 16,
        SoundIoFormatFloat64LE = 17,
        SoundIoFormatFloat64BE = 18,
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoChannelLayout // soundio.h (302, 8)
    {
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @name;
        public int @channel_count;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [CTypeDetails("ConstArrayOf<SoundIoChannelId>")] public SoundIoChannelId[] @channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoSampleRateRange // soundio.h (309, 8)
    {
        public int @min;
        public int @max;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoChannelArea // soundio.h (315, 8)
    {
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @ptr;
        public int @step;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIo // soundio.h (324, 8)
    {
        [CTypeDetails("Pointer<void>")] public System.IntPtr @userdata;
        [CTypeDetails("Pointer<void (SoundIo *)>")] public delegate0 @on_devices_change;
        [CTypeDetails("Pointer<void (SoundIo *, int)>")] public delegate1 @on_backend_disconnect;
        [CTypeDetails("Pointer<void (SoundIo *)>")] public Delegates.delegate0 @on_events_signal;
        public SoundIoBackend @current_backend;
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @app_name;
        [CTypeDetails("Pointer<void ()>")] public delegate2 @emit_rtprio_warning;
        [CTypeDetails("Pointer<void (const char *)>")] public delegate3 @jack_info_callback;
        [CTypeDetails("Pointer<void (const char *)>")] public Delegates.delegate3 @jack_error_callback;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoDevice // soundio.h (383, 8)
    {
        [CTypeDetails("Pointer<SoundIo>")] public System.IntPtr @soundio;
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @id;
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @name;
        public SoundIoDeviceAim @aim;
        [CTypeDetails("Pointer<SoundIoChannelLayout>")] public System.IntPtr @layouts;
        public int @layout_count;
        public SoundIoChannelLayout @current_layout;
        [CTypeDetails("Pointer<SoundIoFormat>")] public System.IntPtr @formats;
        public int @format_count;
        public SoundIoFormat @current_format;
        [CTypeDetails("Pointer<SoundIoSampleRateRange>")] public System.IntPtr @sample_rates;
        public int @sample_rate_count;
        public int @sample_rate_current;
        public double @software_latency_min;
        public double @software_latency_max;
        public double @software_latency_current;
        public bool @is_raw;
        public int @ref_count;
        public int @probe_error;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoOutStream // soundio.h (493, 8)
    {
        [CTypeDetails("Pointer<SoundIoDevice>")] public System.IntPtr @device;
        public SoundIoFormat @format;
        public int @sample_rate;
        public SoundIoChannelLayout @layout;
        public double @software_latency;
        [CTypeDetails("Pointer<void>")] public System.IntPtr @userdata;
        [CTypeDetails("Pointer<void (SoundIoOutStream *, int, int)>")] public delegate4 @write_callback;
        [CTypeDetails("Pointer<void (SoundIoOutStream *)>")] public delegate5 @underflow_callback;
        [CTypeDetails("Pointer<void (SoundIoOutStream *, int)>")] public delegate6 @error_callback;
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @name;
        public bool @non_terminal_hint;
        public int @bytes_per_frame;
        public int @bytes_per_sample;
        public int @layout_error;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoInStream // soundio.h (595, 8)
    {
        [CTypeDetails("Pointer<SoundIoDevice>")] public System.IntPtr @device;
        public SoundIoFormat @format;
        public int @sample_rate;
        public SoundIoChannelLayout @layout;
        public double @software_latency;
        [CTypeDetails("Pointer<void>")] public System.IntPtr @userdata;
        [CTypeDetails("Pointer<void (SoundIoInStream *, int, int)>")] public delegate7 @read_callback;
        [CTypeDetails("Pointer<void (SoundIoInStream *)>")] public delegate8 @overflow_callback;
        [CTypeDetails("Pointer<void (SoundIoInStream *, int)>")] public delegate9 @error_callback;
        [CTypeDetails("Pointer<byte>")] public System.IntPtr @name;
        public bool @non_terminal_hint;
        public int @bytes_per_frame;
        public int @bytes_per_sample;
        public int @layout_error;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct SoundIoRingBuffer // soundio.h (1167, 8)
    {
    }

    partial class Natives
    {
        const string LibraryName = "libsoundio";
        // function soundio_version_string - soundio.h (677, 28)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_version_string();

        // function soundio_version_major - soundio.h (679, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_version_major();

        // function soundio_version_minor - soundio.h (681, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_version_minor();

        // function soundio_version_patch - soundio.h (683, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_version_patch();

        // function soundio_create - soundio.h (689, 32)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_create();

        // function soundio_destroy - soundio.h (690, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_destroy([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_connect - soundio.h (700, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_connect([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_connect_backend - soundio.h (712, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_connect_backend([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio, SoundIoBackend @backend);

        // function soundio_disconnect - soundio.h (713, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_disconnect([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_strerror - soundio.h (716, 28)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_strerror(int @error);

        // function soundio_backend_name - soundio.h (718, 28)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_backend_name(SoundIoBackend @backend);

        // function soundio_backend_count - soundio.h (721, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_backend_count([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_get_backend - soundio.h (724, 36)
        [DllImport(LibraryName)]
        internal static extern SoundIoBackend soundio_get_backend([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio, int @index);

        // function soundio_have_backend - soundio.h (727, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_have_backend(SoundIoBackend @backend);

        // function soundio_flush_events - soundio.h (751, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_flush_events([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_wait_events - soundio.h (755, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_wait_events([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_wakeup - soundio.h (758, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_wakeup([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_force_device_scan - soundio.h (775, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_force_device_scan([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_channel_layout_equal - soundio.h (782, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_channel_layout_equal([CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @a, [CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @b);

        // function soundio_get_channel_name - soundio.h (786, 28)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_get_channel_name(SoundIoChannelId @id);

        // function soundio_parse_channel_id - soundio.h (790, 38)
        [DllImport(LibraryName)]
        internal static extern SoundIoChannelId soundio_parse_channel_id([CTypeDetails("Pointer<byte>")]System.IntPtr @str, int @str_len);

        // function soundio_channel_layout_builtin_count - soundio.h (793, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_channel_layout_builtin_count();

        // function soundio_channel_layout_get_builtin - soundio.h (798, 51)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_channel_layout_get_builtin(int @index);

        // function soundio_channel_layout_get_default - soundio.h (801, 51)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_channel_layout_get_default(int @channel_count);

        // function soundio_channel_layout_find_channel - soundio.h (804, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_channel_layout_find_channel([CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @layout, SoundIoChannelId @channel);

        // function soundio_channel_layout_detect_builtin - soundio.h (809, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_channel_layout_detect_builtin([CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @layout);

        // function soundio_best_matching_channel_layout - soundio.h (814, 51)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_best_matching_channel_layout([CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @preferred_layouts, int @preferred_layout_count, [CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @available_layouts, int @available_layout_count);

        // function soundio_sort_channel_layouts - soundio.h (819, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_sort_channel_layouts([CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @layouts, int @layout_count);

        // function soundio_get_bytes_per_sample - soundio.h (825, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_get_bytes_per_sample(SoundIoFormat @format);

        // function soundio_get_bytes_per_frame - soundio.h (828, 19)
        [DllImport(LibraryName)]
        internal static extern int soundio_get_bytes_per_frame(SoundIoFormat @format, int @channel_count);

        // function soundio_get_bytes_per_second - soundio.h (833, 19)
        [DllImport(LibraryName)]
        internal static extern int soundio_get_bytes_per_second(SoundIoFormat @format, int @channel_count, int @sample_rate);

        // function soundio_format_string - soundio.h (840, 29)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_format_string(SoundIoFormat @format);

        // function soundio_input_device_count - soundio.h (856, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_input_device_count([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_output_device_count - soundio.h (859, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_output_device_count([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_get_input_device - soundio.h (865, 38)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_get_input_device([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio, int @index);

        // function soundio_get_output_device - soundio.h (870, 38)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_get_output_device([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio, int @index);

        // function soundio_default_input_device_index - soundio.h (875, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_default_input_device_index([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_default_output_device_index - soundio.h (880, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_default_output_device_index([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio);

        // function soundio_device_ref - soundio.h (883, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_device_ref([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device);

        // function soundio_device_unref - soundio.h (886, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_device_unref([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device);

        // function soundio_device_equal - soundio.h (890, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_device_equal([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @a, [CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @b);

        // function soundio_device_sort_channel_layouts - soundio.h (895, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_device_sort_channel_layouts([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device);

        // function soundio_device_supports_format - soundio.h (899, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_device_supports_format([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device, SoundIoFormat @format);

        // function soundio_device_supports_layout - soundio.h (904, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_device_supports_layout([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device, [CTypeDetails("Pointer<SoundIoChannelLayout>")]System.IntPtr @layout);

        // function soundio_device_supports_sample_rate - soundio.h (909, 21)
        [DllImport(LibraryName)]
        internal static extern bool soundio_device_supports_sample_rate([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device, int @sample_rate);

        // function soundio_device_nearest_sample_rate - soundio.h (914, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_device_nearest_sample_rate([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device, int @sample_rate);

        // function soundio_outstream_create - soundio.h (924, 41)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_outstream_create([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device);

        // function soundio_outstream_destroy - soundio.h (926, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_outstream_destroy([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream);

        // function soundio_outstream_open - soundio.h (950, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_open([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream);

        // function soundio_outstream_start - soundio.h (961, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_start([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream);

        // function soundio_outstream_begin_write - soundio.h (993, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_begin_write([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream, [CTypeDetails("Pointer<System.IntPtr>")]System.IntPtr @areas, [CTypeDetails("Pointer<int>")]System.IntPtr @frame_count);

        // function soundio_outstream_end_write - soundio.h (1005, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_end_write([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream);

        // function soundio_outstream_clear_buffer - soundio.h (1020, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_clear_buffer([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream);

        // function soundio_outstream_pause - soundio.h (1041, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_pause([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream, bool @pause);

        // function soundio_outstream_get_latency - soundio.h (1054, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_outstream_get_latency([CTypeDetails("Pointer<SoundIoOutStream>")]System.IntPtr @outstream, [CTypeDetails("Pointer<double>")]System.IntPtr @out_latency);

        // function soundio_instream_create - soundio.h (1064, 40)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_instream_create([CTypeDetails("Pointer<SoundIoDevice>")]System.IntPtr @device);

        // function soundio_instream_destroy - soundio.h (1066, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_instream_destroy([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream);

        // function soundio_instream_open - soundio.h (1086, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_instream_open([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream);

        // function soundio_instream_start - soundio.h (1095, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_instream_start([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream);

        // function soundio_instream_begin_read - soundio.h (1126, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_instream_begin_read([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream, [CTypeDetails("Pointer<System.IntPtr>")]System.IntPtr @areas, [CTypeDetails("Pointer<int>")]System.IntPtr @frame_count);

        // function soundio_instream_end_read - soundio.h (1136, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_instream_end_read([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream);

        // function soundio_instream_pause - soundio.h (1149, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_instream_pause([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream, bool @pause);

        // function soundio_instream_get_latency - soundio.h (1159, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_instream_get_latency([CTypeDetails("Pointer<SoundIoInStream>")]System.IntPtr @instream, [CTypeDetails("Pointer<double>")]System.IntPtr @out_latency);

        // function soundio_ring_buffer_create - soundio.h (1173, 42)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_ring_buffer_create([CTypeDetails("Pointer<SoundIo>")]System.IntPtr @soundio, int @requested_capacity);

        // function soundio_ring_buffer_destroy - soundio.h (1174, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_ring_buffer_destroy([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

        // function soundio_ring_buffer_capacity - soundio.h (1178, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_ring_buffer_capacity([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

        // function soundio_ring_buffer_write_ptr - soundio.h (1181, 22)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_ring_buffer_write_ptr([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

        // function soundio_ring_buffer_advance_write_ptr - soundio.h (1183, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_ring_buffer_advance_write_ptr([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer, int @count);

        // function soundio_ring_buffer_read_ptr - soundio.h (1186, 22)
        [DllImport(LibraryName)]
        internal static extern System.IntPtr soundio_ring_buffer_read_ptr([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

        // function soundio_ring_buffer_advance_read_ptr - soundio.h (1188, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_ring_buffer_advance_read_ptr([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer, int @count);

        // function soundio_ring_buffer_fill_count - soundio.h (1191, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_ring_buffer_fill_count([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

        // function soundio_ring_buffer_free_count - soundio.h (1194, 20)
        [DllImport(LibraryName)]
        internal static extern int soundio_ring_buffer_free_count([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

        // function soundio_ring_buffer_clear - soundio.h (1197, 21)
        [DllImport(LibraryName)]
        internal static extern void soundio_ring_buffer_clear([CTypeDetails("Pointer<SoundIoRingBuffer>")]System.IntPtr @ring_buffer);

    }

    class Delegates
    {
        public delegate void delegate0(System.IntPtr p0);
        public delegate void delegate1(System.IntPtr p0, int p1);
        public delegate void delegate2();
        public delegate void delegate3(System.IntPtr p0);
        public delegate void delegate4(System.IntPtr p0, int p1, int p2);
        public delegate void delegate5(System.IntPtr p0);
        public delegate void delegate6(System.IntPtr p0, int p1);
        public delegate void delegate7(System.IntPtr p0, int p1, int p2);
        public delegate void delegate8(System.IntPtr p0);
        public delegate void delegate9(System.IntPtr p0, int p1);
    }

    public struct Pointer<T>
    {
        public IntPtr Handle;
        public static implicit operator IntPtr(Pointer<T> value) { return value.Handle; }
        public static implicit operator Pointer<T>(IntPtr value) { return new Pointer<T>(value); }

        public Pointer(IntPtr handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is Pointer<T> && this == (Pointer<T>)obj;
        }

        public override int GetHashCode()
        {
            return (int)Handle;
        }

        public static bool operator ==(Pointer<T> p1, Pointer<T> p2)
        {
            return p1.Handle == p2.Handle;
        }

        public static bool operator !=(Pointer<T> p1, Pointer<T> p2)
        {
            return p1.Handle != p2.Handle;
        }
    }
    public struct ArrayOf<T> { }
    public struct ConstArrayOf<T> { }
    public class CTypeDetailsAttribute : Attribute
    {
        public CTypeDetailsAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }

}