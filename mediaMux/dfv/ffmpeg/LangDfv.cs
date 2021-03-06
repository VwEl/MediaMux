﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace df
{
    public class LangDfv
    {
        public string Pause = "Pause";
        public string Play = "Play";
        public string Preview = "Preview";
        public string File = "File";
        public string Start = "Start";
        public string Menu = "Menu";
        public string Yes = "Yes";
        public string No = "No";
        public string Ok = "Ok";
        public string SelectFile = "Select files:";
        public string SaveFile = "Save file:";
        public string AddFiles = "Add files";
        public string AllFiles = "All files";
        public string Info = "Info";
        public string Warning = "Warning";
        public string Error = "Error";
        public string Preferences = "Preferences";
        public string Save_as = "Save as";
        public string Copy = "Copy";
        public string Failed = "Failed";
        public string Save = "Save";
        public string Remove = "Remove";
        public string Task_aborted = "Task aborted.";
        public string Already_has_a_task = "Already has a task on processing.";
        public string Please_add_extension = "Please add file's extension.";
        public string Please_add_file_name = "Please add destination file's name.";
        public string Could_not_found_FFmpeg_fileName = "Could not found FFmpeg's fileName!";
        public string At_least_one_stream = "At least select one stream.";

        public string Command_cant_empty = "Command line can not be empty!";

        public string Please_input_two_time = "Please input at least two time stamp.";
        public string Please_input_time = "Please input time.";
        public string next_frame = "Next frame (F)";
        public string copy_timestamp = "Copy timestamp";

        public string make_selection = "Make selection";
        public string cancel_selection = "Cancel selection";

        public string effect = "effect";
        public string time = "time";
        public string loop = "loop";
        public string loop_description = "Loop video or image frames, must appoint end_time or shortest at the same time, otherwise encoding will never stop";

        public string concat = "concat";
        public string command_line = "command line";

        public string fade_in = "fade in";
        public string fade_out = "fade out";

        public string filters = "filters";

        public string video_filters = "video filters";
        public string video_filters_descr = "video filters";

        public string audio_filters = "audio filters";
        public string audio_filters_descr = "audio filters";

        public string deinterlace = "deinterlace";
        public string deinterlace_descr = @"Deinterlace the input video (bwdif, Bob Weaver Deinterlacing Filter).
‘0, send_frame’Output one frame for each frame. ‘1, send_field’Output one frame for each field. ";

        public string horizon_flip = "horizon flip";
        public string vertical_flip = "vertical flip";

        public string scale = "scale";
        public string scale_descr = @"Scale (resize) the input video. The scale filter forces the output display aspect ratio to be the same of the input, by changing the output sample aspect ratio. 
If the input image format is different from the format requested by the next filter, the scale filter will convert the input to the requested format. 
";
        public string flags = "flags";
        public string flags_descr = "Set the scaling algorithm. Default value is ‘bicubic’. ";

        public string wh_descr = "Set the output video dimension.If the value is -1,it will keep the aspect ratio of the input image";

        public string setsar = "set sar";
        public string setsar_descr = "Set the sample aspect ratio used by the filter.The parameter can be a floating point number string, an expression, or a string of the form num:den, where num and den are the numerator and denominator of the aspect ratio. If the parameter is not specified, it is assumed the value '0'. In case the form 'num:den' is used, the : character should be escaped. ";

        public string color_adjustment = "color adjustment";
        public string color_adjustment_descr = @"Set brightness, contrast, saturation and approximate gamma adjustment. ";

        public string best_quality = "best quality";
        public string default_ = "default";
        public string low_quality = "low quality";

        public string Help = "Help";

        public string delay = "delay";
        public string delay_descr = "Set list of delays in milliseconds for each channel separated by ’|’. Unused delays will be silently ignored. If number of given delays is smaller than number of channels all remaining channels will not be delayed. If you want to delay exact number of samples, append ’S’ to number. ";
        public string tempo = "tempo";
        public string tempo_descr = @"The filter accepts exactly one parameter, the audio tempo. If not specified then the filter will assume nominal 1.0 tempo. Tempo must be in the [0.5, 100.0] range. 
Note that tempo greater than 2 will skip some samples rather than blend them in. If for any reason this is a concern it is always possible to daisy-chain several instances of atempo to achieve the desired product tempo.";
        public string volume = "volume";
        public string volume_descr = "The default value for volume is '1.0'. ";
        public string mix_audio = "mix audio";
        public string mix_audio_descr = @"Mixes multiple audio inputs into a single output. 
Note that this filter only supports float samples. If the amix input has integer samples then aresample will be automatically inserted to perform the conversion to float samples.";
        public string mix_shortest = "mix shortest";
        public string mix_shortest_descr = "Use the duration of shortest input as the end-of-stream.";


        public string audio = "audio";
        public string video = "video";
        public string subtitle = "subtitle";
        public string attachment = "attachment";
        public string audio_ = "1.audio";
        public string video_ = "2.video";

        public string About = "About";
        public string version = "version";
        public string Edit = "Edit";
        public string Details = "Details";
        public string ext = "container";
        public string ext_descr = "";
        public string audio_code = "audio code";
        public string audio_code_descr = "";
        public string audio_bit_rate = "audio bit rate";
        public string audio_bit_rate_descr = "Set constant bit rate, The unit is kbits/s";
        public string audio_channels = "audio channels";
        public string audio_channels_descr = "Set the number of audio channels.";
        public string audio_sample_rate = "audio sample rate";
        public string audio_sample_rate_descr = "The unit is Hz, Set the audio sampling frequency.";
        public string video_code = "video code";
        public string video_code_descr = "'_nvenc' indicating NVIDIA GPU Hardware Acceleration, '_qsv' indicating Intel GPU Acceleration QuickSync. ";
        public string video_crf = "video quality(crf)";
        public string video_crf_descr = "Set the quality/size tradeoff for constant-quality (no bitrate target) and constrained-quality (with maximum bitrate target) modes. Valid range is 0 to 51, higher numbers indicating lower quality and smaller output size. The default value is '23'.";
        public string video_bit_rate = "video bit rate";
        public string video_bit_rate_descr = "Set constant bit rate, The unit is kbits/s, Recommended use crf instead.";
        public string video_max_bit_rate = "video bit rate max";
        public string video_max_bit_rate_descr = "The unit is kbits/s, must set buffer_size at the same time. otherwise it will be ignored.";
        public string video_buffer_size = "video buffer size";
        public string video_buffer_size_descr = "Rate control buffer, The unit is kbytes. Recommended value same as video bit rate";
        public string video_display_size = "video display size";
        public string video_display_size_descr = "Set frame size. The format is 1920:1080 or 1920:-1 for keep aspect ratio";
        public string video_fps = "video fps";
        public string video_fps_descr = "Set frame rate (Hz value, fraction or abbreviation). ";
        public string video_pixel_format = "video pixel format";
        public string video_pixel_format_descr = " '10le' indicating '10 bit little-endian'";
        public string video_tune = "video tune";
        public string video_tune_descr = "";
        public string display_aspect_ratio = "display aspect ratio";
        public string display_aspect_ratio_descr = "";
        public string preset = "preset";
        public string preset_descr = "This does some automatic settings based on the general type of the image.(default 'medium')";
        public string command_line_descr = "";
        public string keyint_max_descr = @"Recommended default: 250 
Keyframe interval, also known as GOP length. 
This determines the maximum distance between I-frames.
Very high GOP lengths will result in slightly more efficient compression, but will make seeking in the video somewhat more difficult.";
        public string keyint_min_descr = @"Recommended default: 25 
Minimum GOP length, the minimum distance between I-frames.";
        public string bframes_descr = @"Recommended default: 3 
B-frames are a core element of H.264 and are more efficient in H.264 than any previous standard.
Some specific targets, such as HD-DVD and Blu-Ray, have limitations on the number of consecutive B-frames.
Most, however, do not; as a result, there is rarely any negative effect to setting this to the maximum (16) since x264 will, if B-adapt is used, automatically choose the best number of B-frames anyways.
This parameter simply serves to limit the max number of B-frames. Note that Baseline Profile, such as that used by iPods, does not support B-frames.";
        public string qpmax_descr = "Recommended default: 69   Maximum quantizer.";
        public string qpmin_descr = "Recommended default: 0   Minimum quantizer.";
        public string qcomp_descr = @"Recommended default: 0.60 
QP curve compression. h264: 0.0 => CBR, 1.0 => CQP. h265: 0.5 - 1.0";
        public string qpstep_descr = "Set max QP step.  Recommended default: 4";
        public string rc_lookahead_descr = "Set number of frames to look ahead for frametype and ratecontrol.  Recommended default: 20";
        public string x = "x";
        public string x_descr = "";
        public string y = "y";
        public string y_descr = "";
        public string w = "w";
        public string w_descr = "";
        public string h = "h";
        public string h_descr = "";
        public string contrast = "contrast";
        public string contrast_descr = "Default value is '1'. Must be a float value in range -2.0 to 2.0.";
        public string brightness = "brightness";
        public string brightness_descr = "Default value is '0'. Must be a float value in range -1.0 to 1.0.";
        public string saturation = "saturation";
        public string saturation_descr = "Default value is '1'. Must be a float in range 0.0 to 3.0. ";
        public string gamma_red = "gamma red";
        public string gamma_red_descr = "Default value is '1'. Must be a float in range 0.1 to 10.0.";
        public string gamma_green = "gamma green";
        public string gamma_green_descr = "Default value is '1'. Must be a float in range 0.1 to 10.0.";
        public string gamma_blue = "gamma blue";
        public string gamma_blue_descr = "Default value is '1'. Must be a float in range 0.1 to 10.0.";
        public string gamma_weight = "gamma weight";
        public string gamma_weight_descr = "Set the gamma weight expression. It can be used to reduce the effect of a high gamma value on bright image areas, e.g. keep them from getting overamplified and just plain white. The value must be a float in range 0.0 to 1.0. A value of 0.0 turns the gamma correction all the way down while 1.0 leaves it at its full strength. Default is '1'. ";
        public string luma_amount = "luma amount";
        public string luma_amount_descr = "Negative values will blur the input video, while positive values will sharpen it, a value of zero will disable the effect. ";
        public string luma_msize_x = "luma matrix size x";
        public string luma_msize_x_descr = "Set the luma matrix horizontal size. It must be an odd integer between 3 and 23. The default value is 5. ";
        public string luma_msize_y = "luma matrix size y";
        public string luma_msize_y_descr = "Set the luma matrix vertical size. It must be an odd integer between 3 and 23. The default value is 5. ";
        public string color = "color";
        public string color_descr = "";
        public string denoise = "denoise";
        public string denoise_descr = "A non-negative floating point number which specifies spatial luma strength. High precision/quality 3d denoise filter. It aims to reduce image noise, producing smooth images and making still images really still. It should enhance compressibility. ";
        public string start_time = "start time";
        public string end_time = "end time";
        public string duration = "duration";
        public string duration_descr = @"Format is [-][HH:]MM:SS[.m...] or [-]S+[.m...] Examples :
‘55’is 55 seconds 
‘12:03:45’is 12 hours, 03 minutes and 45 seconds 
‘23.189’is 23.189 seconds";
        public string eof_time = "eof time";
        public string eof_time_descr = "Time relative to the 'end of file'. That is negative values are earlier in the file, 0 is at EOF. ";

        public string position = "position";
        public string position_descr = "0.left top 1.right top 2.right bottom 3.left bottom";

        public string Left_top = "Left top";
        public string Right_top = "Right top";
        public string Right_bottom = "Right bottom";
        public string Left_bottom = "Left bottom";
        public string shortest = "shortest";
        public string shortest_descr = "Finish encoding when the shortest input stream ends. ";
        public string concat_descr = "Concatenate audio and video streams, joining them together one after the other. ";

        public string two_pass = "two pass";
        public string two_pass_descr = "";

        public string x26x_params = "x264/x265 params";
        public string x26x_params_descr = "x264 and x265(hevc) common encoding parameters. When use GPU encoding(nvenc/qsv),it will be ignored.";
        public string x265_params = "x265 params";
        public string x265_params_descr = "";
        public string filters_descr = "";
        public string crop = "crop";
        public string crop_descr = "Crop the input video to given dimensions. ";
        public string blur_sharp = "blur sharp";
        public string blur_sharp_descr = "Sharpen or blur the input video.";
        public string delogo = "delogo";
        public string delogo_descr = "Suppress a TV station logo by a simple interpolation of the surrounding pixels. Just set a rectangle covering the logo and watch it disappear (and sometimes something even uglier appear - your mileage may vary). ";
        public string pad = "pad";
        public string pad_descr = "Add paddings to the input image, and place the original input at the provided x, y coordinates. ";
        public string overlay = "overlay";
        public string overlay_descr = "Overlay one video or image on top of another.";

        public string profile = "profile";
        public string profile_descr = "";
        public string level = "level";
        public string level_descr = "";

        public string psy_rd_descr = "Default 2.0 Range of values: 0 .. 5.0 \r\nInfluence rate distortion optimizated mode decision to preserve the energy of the source image in the encoded image at the expense of compression efficiency. It only has effect on presets which use RDO-based mode decisions (--rd 3 and above). 1.0 is a typical value.";
        public string psy_rdoq_descr = "Default: 0.0 (1.0 for presets slow, slower, veryslow).Range of values: 0 .. 50.0 \r\nInfluence rate distortion optimized quantization by favoring higher energy in the reconstructed image. This generally improves perceived visual quality at the cost of lower quality metric scores. It only has effect when --rdoq-level is 1 or 2. High values can be beneficial in preserving high-frequency detail.";
        public string deblock_descr = @"Default 0:0 ";
        public string ref_descr = "Default 3 Max number of L0 references to be allowed. This number has a linear multiplier effect on the amount of work performed in motion search, but will generally have a beneficial affect on compression and distortion.";

        public string aq_mode_descr = @"Adaptive Quantization operating mode. Raise or lower per-block quantization based on complexity analysis of the source image. The more complex the block, the more quantization is used. This offsets the tendency of the encoder to spend too many bits on complex areas and not enough in flat areas.
0.disabled
1.AQ enabled (default)
2.AQ enabled with auto-variance
3. AQ enabled with auto-variance and bias to dark scenes. This is recommended for 8-bit encodes or low-bitrate 10-bit encodes, to prevent color banding/blocking.";
        public string aq_strength_descr = @"Adjust the strength of the adaptive quantization offsets. Setting --aq-strength to 0 disables AQ. At aq-modes 2 and 3, high aq-strengths will lead to high QP offsets resulting in a large difference in achieved bitrates.
Default 1.0. Range of values: 0.0 to 3.0";

        public string strong_intra_smoothing_descr = "Enable strong intra smoothing for 32x32 intra blocks. This flag performs bi-linear interpolation of the corner reference samples for a strong smoothing effect. The purpose is to prevent blocking or banding artifacts in regions with few/zero AC coefficients. Default enabled";
        public string amp_descr = @"Enable analysis of asymmetric motion partitions (75/25 splits, four directions). At RD levels 0 through 4, AMP partitions are only considered at CU sizes 32x32 and below. At RD levels 5 and 6, it will only consider AMP partitions as merge candidates (no motion search) at 64x64, and as merge or inter candidates below 64x64.
The AMP partitions which are searched are derived from the current best inter partition. If Nx2N (vertical rectangular) is the best current prediction, then left and right asymmetrical splits will be evaluated. If 2NxN (horizontal rectangular) is the best current prediction, then top and bottom asymmetrical splits will be evaluated, If 2Nx2N is the best prediction, and the block is not a merge/skip, then all four AMP partitions are evaluated.
This setting has no effect if rectangular partitions are disabled. Default disabled";
        public string ssim_rd_descr = @"Enable/Disable SSIM RDO. SSIM is a better perceptual quality assessment method as compared to MSE. SSIM based RDO calculation is based on residual divisive normalization scheme. This normalization is consistent with the luminance and contrast masking effect of Human Visual System. It is used for mode selection during analysis of CTUs and can achieve significant gain in terms of objective quality metrics SSIM and PSNR. It only has effect on presets which use RDO-based mode decisions (--rd 3 and above).";
        public string pmode_descr = @"Parallel mode decision, or distributed mode analysis. When enabled the encoder will distribute the analysis work of each CU (merge, inter, intra) across multiple worker threads. Only recommended if x265 is not already saturating the CPU cores. In RD levels 3 and 4 it will be most effective if –rect is enabled. At RD levels 5 and 6 there is generally always enough work to distribute to warrant the overhead, assuming your CPUs are not already saturated.
–pmode will increase utilization without reducing compression efficiency. In fact, since the modes are all measured in parallel it makes certain early-outs impractical and thus you usually get slightly better compression when it is enabled (at the expense of not skipping improbable modes). This bypassing of early-outs can cause pmode to slow down encodes, especially at faster presets.
This feature is implicitly disabled when no thread pool is present.
Default disabled";

        public string constrained_intra_descr = @"Constrained intra prediction. When generating intra predictions for blocks in inter slices, only intra-coded reference pixels are used. Inter-coded reference pixels are replaced with intra-coded neighbor pixels or default values. The general idea is to block the propagation of reference errors that may have resulted from lossy signals. Default disabled";
        public string rect_descr = @"Enable analysis of rectangular motion partitions Nx2N and 2NxN (50/50 splits, two directions). Default disabled";
        public string merange_descr = "Maximum motion vector search range.x265 Default 57. x264 default 16";

        public string sao_descr = "Toggle Sample Adaptive Offset loop filter, default enabled";
        public string weightp_descr = "Default is enabled. Enable weighted prediction in P slices. This enables weighting analysis in the lookahead, which influences slice decisions, and enables weighting analysis in the main encoder which allows P reference samples to have a weight function applied to them prior to using them for motion compensation. In video which has lighting changes, it can give a large improvement in compression efficiency. ";
        public string weightb_descr = "Default disabled. Enable weighted prediction in B slices. ";

        public string audio_quality = "audio quality";
        public string audio_quality_descr = "Set the audio quality (codec-specific, VBR).";

        public string dynaudnorm = "dynamic normalizer";
        public string dynaudnorm_descr = @"This filter applies a certain amount of gain to the input audio in order to bring its peak magnitude to a target level (e.g. 0 dBFS).";


        public string gradfun = "fix banding";
        public string gradfun_descr = @"Fix the banding artifacts that are sometimes introduced into nearly flat regions by truncation to 8-bit color depth. Interpolate the gradients that should go where the bands are, and dither them.
It is designed for playback only.Do not use it prior to lossy compression, because compression tends to lose the dither and bring back the bands.
It accepts the following parameters:

‘strength’
The maximum amount by which the filter will change any one pixel. This is also the threshold for detecting nearly flat regions. Acceptable values range from .51 to 64; the default value is 1.2. Out-of-range values will be clipped to the valid range.

‘radius’
The neighborhood to fit the gradient to.A larger radius makes for smoother gradients, but also prevents the filter from modifying the pixels near detailed regions.Acceptable values are 8-32; the default value is 16. Out-of-range values will be clipped to the valid range.

Alternatively, the options can be specified as a flat string: strength[:radius]";


        public string rotate = "rotate";
        public string rotate_descr = "Rotate video by an arbitrary angle expressed in radians.";
        public string angle = "angle";
        public string angle_descr = "Set an expression for the angle by which to rotate the input video clockwise, expressed as a number of radians. A negative value will result in a counter-clockwise rotation. By default it is set to '0'.";
        public string out_w = "out w";
        public string out_w_descr = "Set the output width expression, default value is 'iw'. This expression is evaluated just once during configuration.";
        public string out_h = "out h";
        public string out_h_descr = "Set the output height expression, default value is 'ih'. This expression is evaluated just once during configuration.";
        public string fillcolor = "fill color";
        public string fillcolor_descr = "Set the color used to fill the output area not covered by the rotated image.";


        public string setpts = "set pts";
        public string setpts_descr = "Change the PTS (presentation timestamp) of the input frames.";

        public string rd_descr = "Level of RDO in mode decision. The higher the value, the more exhaustive the analysis and the more rate distortion optimization is used. The lower the value the faster the encode, the higher the value the smaller the bitstream (in general). Default 3";
        public string ctu_descr = "Maximum CU size (width and height). The larger the maximum CU size, the more efficiently x265 can encode flat areas of the picture, giving large reductions in bitrate. However this comes at a loss of parallelism with fewer rows of CUs that can be encoded in parallel, and less frame parallelism as well. Because of this the faster presets use a CU size of 32. Default: 64";
        public string scenecut_descr = "How aggressively I-frames need to be inserted. The higher the threshold value, the more aggressive the I-frame placement. --scenecut 0 disables adaptive I frame placement. Default 40";


        public string early_skip = "Measure 2Nx2N merge candidates first; if no residual is found, additional modes at that depth are not analysed. Default disabled";
        public string fast_intra = "Perform an initial scan of every fifth intra angular mode, then check modes +/- 2 distance from the best mode, then +/- 1 distance from the best mode, effectively performing a gradient descent. When enabled 10 modes in total are checked. When disabled all 33 angular modes are checked. Only applicable for --rd levels 4 and below (medium preset and faster).";

        public string rskip_descr = "This option determines early exit from CU depth recursion. When a skip CU is found, additional heuristics (depending on rd-level) are used to decide whether to terminate recursion. In rdlevels 5 and 6, comparison with inter2Nx2N is used, while at rdlevels 4 and neighbour costs are used to skip recursion. Provides minimal quality degradation at good performance gains when enabled.\r\nDefault: enabled, disabled for --tune grain";
        public string splitrd_skip_descr = "Enable skipping split RD analysis when sum of split CU rdCost larger than one split CU rdCost for Intra CU. Default disabled.";
        public string b_intra_descr = "Enables the evaluation of intra modes in B slices. Default disabled.";
    }
}
